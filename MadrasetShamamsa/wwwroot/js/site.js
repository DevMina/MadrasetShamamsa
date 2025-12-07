$(document).ready(function () {
    /**
     * Configuration object for Somee ads handling
     * Centralize settings for easier maintenance
     */
    const SomeeConfig = {
        domain: 'somee.com',
        adsDomain: 'ads.mgmt.somee.com',
        debounceDelay: 500,
        maxRetries: 3,
        retryDelay: 1000
    };

    /**
     * Enhanced Somee Ads Handler
     * Removes duplicate ad content while preserving one instance
     */
    const SomeeAdsHandler = {
        // Track state to prevent multiple simultaneous runs
        isRunning: false,
        retryCount: 0,

        /**
         * Remove duplicate center tags with Somee links
         * Keeps the last one, removes all others
         */
        removeDuplicateCenterTags() {
            try {
                const $centerTags = $(`center > a[href*="${SomeeConfig.domain}"]`).closest('center');
                const totalCount = $centerTags.length;

                if (totalCount <= 1) return; // Nothing to remove

                // Remove all except the last one
                $centerTags.slice(0, -1).remove();

                if (totalCount > 1) {
                    console.info(`[Somee Ads] Removed ${totalCount - 1} duplicate center tag(s)`);
                }
            } catch (error) {
                console.warn('[Somee Ads] Error removing center tags:', error);
            }
        },

        /**
         * Remove duplicate ad scripts
         * Keeps the first one, removes all subsequent duplicates
         */
        removeDuplicateScripts() {
            try {
                const scriptTracking = {
                    external: false,
                    inline: false
                };

                $('script').each((index, scriptElement) => {
                    const $script = $(scriptElement);
                    const src = scriptElement.src || '';
                    const content = scriptElement.textContent || '';

                    // Check for external ads script
                    if (src.includes(SomeeConfig.adsDomain)) {
                        if (scriptTracking.external) {
                            $script.remove();
                            console.info(`[Somee Ads] Removed duplicate external script at index ${index}`);
                        } else {
                            scriptTracking.external = true;
                        }
                    }
                    // Check for inline ads script
                    else if (content.includes(SomeeConfig.adsDomain)) {
                        if (scriptTracking.inline) {
                            $script.remove();
                            console.info(`[Somee Ads] Removed duplicate inline script at index ${index}`);
                        } else {
                            scriptTracking.inline = true;
                        }
                    }
                });
            } catch (error) {
                console.warn('[Somee Ads] Error removing scripts:', error);
            }
        },

        /**
         * Main handler function
         * Orchestrates the cleanup process
         */
        handle() {
            // Prevent concurrent executions
            if (this.isRunning) return;
            this.isRunning = true;

            try {
                this.removeDuplicateCenterTags();
                this.removeDuplicateScripts();
                this.retryCount = 0; // Reset on success
            } catch (error) {
                console.error('[Somee Ads] Unexpected error:', error);

                // Retry mechanism for transient failures
                if (this.retryCount < SomeeConfig.maxRetries) {
                    this.retryCount++;
                    setTimeout(() => {
                        this.isRunning = false;
                        this.handle();
                    }, SomeeConfig.retryDelay);
                }
            } finally {
                this.isRunning = false;
            }
        }
    };

    /**
     * Debounced version of the handler
     * Prevents excessive execution during rapid AJAX calls
     */
    let debounceTimer = null;
    const debouncedHandler = () => {
        clearTimeout(debounceTimer);
        debounceTimer = setTimeout(() => {
            SomeeAdsHandler.handle();
        }, SomeeConfig.debounceDelay);
    };

    // Initial cleanup on page load
    SomeeAdsHandler.handle();

    // Hook into AJAX success events
    $(document).on('ajaxSuccess', debouncedHandler);

    /**
     * Optional: Monitor for dynamically added content
     * Using MutationObserver for better performance than polling
     */
    if (window.MutationObserver) {
        try {
            const observer = new MutationObserver(debounceHandler);
            observer.observe(document.body, {
                childList: true,
                subtree: true,
                attributes: false,
                characterData: false
            });

            // Store reference for potential cleanup
            window.someeObserver = observer;
        } catch (error) {
            console.warn('[Somee Ads] MutationObserver setup failed, falling back to AJAX only:', error);
        }
    }

    // Expose handler for manual triggering if needed
    window.cleanupSomeeAds = () => SomeeAdsHandler.handle();
});