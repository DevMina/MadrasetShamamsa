$(document).ready(function () {
    /**
     * Accordion Auto-Scroll Handler
     * Automatically scrolls to accordion header when expanded
     */
    const AccordionScrollHandler = {
        headerOffset: 80, // Adjust based on your fixed header height
        scrollDuration: 400,

        /**
         * Initialize accordion scroll behavior
         */
        init() {
            // Handle all accordions on the page
            $('.accordion').each((index, accordion) => {
                const $accordion = $(accordion);

                // Use a small delay to let Bootstrap finish its animation first
                $accordion.on('shown.bs.collapse', (event) => {
                    setTimeout(() => {
                        this.scrollToAccordion(event);
                    }, 50);
                });
            });

            console.info('[Accordion] Auto-scroll handler initialized');
        },

        /**
         * Scroll to the expanded accordion
         */
        scrollToAccordion(event) {
            try {
                const $accordionItem = $(event.target).closest('.accordion-item');

                if ($accordionItem.length) {
                    const targetOffset = $accordionItem.offset().top - this.headerOffset - 20;

                    // Stop any ongoing scroll animations first
                    $('html, body').stop().animate({
                        scrollTop: targetOffset
                    }, this.scrollDuration);
                }
            } catch (error) {
                console.warn('[Accordion] Error scrolling to accordion:', error);
            }
        },

        /**
         * Update header offset dynamically
         */
        updateHeaderOffset(newOffset) {
            this.headerOffset = newOffset;
        }
    };

    // Initialize accordion scroll handler
    AccordionScrollHandler.init();

    // Expose for external configuration if needed
    window.updateAccordionOffset = (offset) => AccordionScrollHandler.updateHeaderOffset(offset);
});