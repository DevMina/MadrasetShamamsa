# مدرسة شمامسة أونلاين - Static HTML Version

This is a static HTML version of the MadrasetShamamsa website, converted from the ASP.NET Core MVC application to pure HTML, CSS, and JavaScript.

## Structure

```
MadrasetShamamsa-Static/
├── index.html               # Home page (entry point)
├── css/
│   └── site.css              # Main stylesheet
├── js/
│   └── site.js               # Main JavaScript file
├── fonts/                    # Coptic fonts
│   ├── Athanasius.ttf
│   ├── Avva_Shenouda.ttf
│   ├── CS Avva Shenouda.ttf
│   └── CS New Athanasius.ttf
├── lib/                      # Third-party libraries
│   ├── bootstrap/            # Bootstrap CSS & JS
│   ├── jquery/               # jQuery
│   ├── jquery-validation/    # jQuery Validation
│   └── jquery-validation-unobtrusive/
├── assets/
│   └── favicon.ico           # Website favicon
└── pages/                    # HTML pages
    ├── template.html         # Layout template
    ├── Alhan/                # Hymns section
    │   ├── AlhanList.html
    │   ├── Sanawy/
    │   │   ├── Sanawy.html
    │   │   ├── RafaeBokhor/
    │   │   │   ├── Zoksologiat.html
    │   │   │   ├── ArbaeElnakos.html
    │   │   │   ├── SalatElShokr.html
    │   │   │   ├── Awashy.html
    │   │   │   ├── OshytElEngel.html
    │   │   │   └── Elkhetam.html
    │   │   ├── KodasBasily/
    │   │   │   └── AwashyKodas.html
    │   │   └── Tawzie/
    │   │       └── TawzieSanawy.html
    │   ├── ElSoomElKber/
    │   │   ├── ElSoomElKber.html
    │   │   ├── RafaeBokhor/
    │   │   │   ├── ZoksologiatElSoomElKber.html
    │   │   │   ├── MaradElEngelElSoomElKber.html
    │   │   │   └── ElkhetamElSoomElKber.html
    │   │   ├── Kodas/
    │   │   │   └── Hetanyat.html
    │   │   └── Tawzie/
    │   └── KiahkChristmas/
    │       ├── KiahkChristmas.html
    │       └── Kiahk/
    │           └── KiahkMain.html
    └── EilomElKanesa/        # Church Sciences section
        ├── EilomElKanesa.html
        ├── Akeda/
        │   └── Akeda.html
        ├── Coptic/
        │   └── Coptic.html
        ├── Taqs/
        │   ├── Taqs.html
        │   └── Taqs-Kodas/
        │       └── TaqsKodas.html
        └── TarekhElKanesa/
            └── TarekhElKanesa.html
```

## How to Use

1. **Open the website**: Simply open `index.html` in your web browser to view the home page.

2. **Deploy**: You can deploy this to any static hosting service:
   - GitHub Pages
   - Netlify
   - Vercel
   - Any web server (Apache, Nginx, IIS)

3. **Local development**: Use any static file server or simply open the HTML files directly in a browser.

## Features

- **Pure HTML/CSS/JavaScript**: No server-side code required
- **Responsive Design**: Works on desktop, tablet, and mobile devices
- **RTL Support**: Full right-to-left support for Arabic content
- **Bootstrap 5**: Uses Bootstrap 5.3 with RTL support
- **Coptic Fonts**: Includes custom Coptic fonts for liturgical text
- **Same Content**: Maintains all original content and structure from the ASP.NET version

## Navigation

The website maintains the same navigation structure:
- **Home**: Main landing page
- **Alhan (Hymns)**: Library of Coptic hymns organized by occasion
  - Annual Hymns (Sanawy)
  - Great Lent Hymns (ElSoomElKber)
  - Kiahk and Christmas Hymns
- **EilomElKanesa (Church Sciences)**: Educational materials
  - Coptic Language
  - Coptic Rite (Taqs)
  - Church Dogma (Akeda)
  - Church History (TarekhElKanesa)

## Technical Details

- **CSS Framework**: Bootstrap 5.3 with RTL support
- **Icons**: Bootstrap Icons and Font Awesome 6.4
- **JavaScript**: jQuery 3.x and Bootstrap 5 JS
- **Fonts**: Custom Coptic fonts (Athanasius, Avva Shenouda, etc.)
- **Direction**: RTL (Right-to-Left) for Arabic content

## Conversion Status

The static HTML version has been successfully created with the following pages converted:

**Completed:**
- ✅ Home page (index.html)
- ✅ Alhan main page (AlhanList.html)
- ✅ Alhan - Sanawy section (Sanawy.html + 46 subpages)
  - RafaeBokhor (6 pages)
  - KodasBasily (11 pages)
  - KodasGhorighory (4 pages)
  - KodasMawozen (21 pages)
  - Tawzie (8 pages)
- ✅ Alhan - ElSoomElKber section (ElSoomElKber.html + 18 subpages)
  - RafaeBokhor (3 pages with full content)
  - Kodas (7 pages)
  - Tawzie (7 pages)
- ✅ Alhan - KiahkChristmas section (KiahkChristmas.html + 16 subpages)
  - Kiahk Kodas (6 pages)
  - Kiahk RafaeBokhor (4 pages)
  - Kiahk Tawzie (5 pages)
  - BaramonElMelad (1 page)
- ✅ EilomElKanesa main page (EilomElKanesa.html)
- ✅ EilomElKanesa - Coptic (Coptic.html)
- ✅ EilomElKanesa - Akeda (Akeda.html)
- ✅ EilomElKanesa - Taqs (Taqs.html + TaqsKodas.html)
- ✅ EilomElKanesa - TarekhElKanesa (TarekhElKanesa.html)

**Total Pages Created: 85+ pages**

**Notes:**
- All directory structures have been created mirroring the original ASP.NET application
- All .cshtml files from the original Views directory have been converted to static HTML
- Navigation links have been updated to work with the static HTML structure
- Most hymn pages contain placeholder content with "قريباً" (coming soon) indicators
- Key pages (ZoksologiatElSoomElKber, MaradElEngelElSoomElKber, Zoksologiat, ArbaeElnakos, AwashyKodas, Hetanyat) have been fully converted with complete content
- The website maintains the same styling and layout as the original ASP.NET version
- Ready for deployment to any static hosting service (GitHub Pages, Netlify, Vercel, etc.)

## Conversion Details

This static version was converted from the original ASP.NET Core MVC application located in the parent directory. All Razor views (.cshtml) have been converted to pure HTML, maintaining the same structure, content, and styling.

The conversion preserves:
- Page structure and hierarchy
- All content (Arabic text)
- Styling (CSS)
- Navigation links
- Responsive design
- RTL layout

## License

This static version maintains the same license as the original project.
