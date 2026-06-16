# MadrasetShamamsa Static Site

This is a static HTML/CSS/JS conversion of the MadrasetShamamsa ASP.NET Core MVC project.

## Structure

The static site maintains the same folder structure and page names as the original project:

- **Home/** - Main pages
  - `Index.html` - Home page
- **Alhan/** - Hymns section
  - `AlhanList.html` - Main hymns list
  - `Sanawy/` - Annual hymns
  - `ElSoomElKber/` - Great Lent hymns
  - `KiahkChristmas/` - Kiahk and Christmas hymns
- **EilomElKanesa/** - Church Sciences section
  - `EilomElKanesa.html` - Main church sciences page
  - `Coptic/` - Coptic language
  - `Taqs/` - Coptic rite
  - `Akeda/` - Church dogma
  - `TarekhElKanesa/` - Church history
- **css/** - Stylesheets
  - `site.css` - Main stylesheet (converted from original)
- **js/** - JavaScript files
  - `site.js` - Main JavaScript file (converted from original)
- **fonts/** - Font files
  - Coptic fonts for displaying Coptic text

## Conversion Details

### What Was Converted

1. **Main Navigation Pages** - All primary pages that are linked from the main navigation
2. **CSS Files** - Updated font paths to be relative to the CSS file location
3. **JavaScript Files** - Copied as-is from the original project
4. **Font Files** - Copied all Coptic fonts
5. **Layout** - Converted ASP.NET Core layout to static HTML template
6. **Alhan/Sanawy/** - All sub-pages for annual hymns (RafaeBokhor folder)
7. **Alhan/ElSoomElKber/** - All sub-pages for Great Lent hymns (RafaeBokhor, Kodas, and Tawzie folders)
8. **Alhan/KiahkChristmas/Kiahk/** - Sub-pages for Kiahk hymns (Kodas and RafaeBokhor folders)
9. **EilomElKanesa/** - Main page and navigation sub-pages (Coptic, Taqs, Akeda, TarekhElKanesa)

### What Needs to Be Completed

The following sub-pages are marked as "قريباً" (coming soon) and need to be converted from their original .cshtml files:

- **EilomElKanesa/** - Detailed content pages for each church science (Coptic, Taqs, Akeda, TarekhElKanesa) - currently showing "coming soon" message
- **Alhan/KiahkChristmas/BaramonElMelad/** - Sub-pages for Christmas Paramoun hymns (placeholder files currently empty)
- **Alhan/KiahkChristmas/Kiahk/Tawzie/** - Sub-pages for Kiahk distribution hymns (placeholder files currently empty)

### How to Complete the Conversion

To convert the remaining .cshtml files to static HTML:

1. Read the original .cshtml file from `MadrasetShamamsa/Views/`
2. Replace Razor syntax (`@...`) with static HTML
3. Replace ASP.NET helpers (`asp-controller`, `asp-action`) with regular HTML links
4. Update paths to be relative to the static site structure
5. Use the template from existing pages as a guide

### Key Changes Made

1. **Font Paths**: Updated from `/fonts/` to `../fonts/` in site.css
2. **CDN Links**: Used CDN links for Bootstrap, jQuery, and Font Awesome instead of local files
3. **Navigation Links**: Converted ASP.NET routing to static HTML relative paths
4. **Layout**: Converted shared layout to individual HTML files with common header/footer

## Usage

To view the static site:

1. Open `static-site/Home/Index.html` in a web browser
2. Or use a local web server like Python's built-in server:
   ```bash
   cd static-site
   python -m http.server 8000
   ```
3. Then navigate to `http://localhost:8000/Home/Index.html`

## Notes

- The Coptic date service from the original project was server-side, so it's replaced with a placeholder JavaScript implementation
- Form submissions (like the contact form) will not work in the static version
- All dynamic content has been converted to static HTML where possible
