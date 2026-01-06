<!doctype html>
<html lang="id" class="h-full">
 <head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>Awalan Design.id - Jasa Desain Grafis UMKM Profesional</title>
  <script src="/_sdk/element_sdk.js"></script>
  <script src="https://cdn.tailwindcss.com"></script>
  <link href="https://fonts.googleapis.com/css2?family=Poppins:wght@300;400;500;600;700;800;900&amp;family=Playfair+Display:wght@700;900&amp;display=swap" rel="stylesheet">
  <style>
    /* ==========================================
       RESET & BASE STYLES
       ========================================== */
    body {
      box-sizing: border-box;
      font-family: 'Poppins', sans-serif;
      margin: 0;
      padding: 0;
    }

    * {
      box-sizing: border-box;
    }

    html {
      scroll-behavior: smooth;
    }

    /* ==========================================
       TYPOGRAPHY
       ========================================== */
    .font-display {
      font-family: 'Playfair Display', serif;
    }

    /* ==========================================
       HERO SECTION STYLES
       ========================================== */
    .hero-bg {
      background: linear-gradient(135deg, #667eea 0%, #764ba2 100%);
      position: relative;
      overflow: hidden;
    }
    
    .hero-bg::before {
      content: '';
      position: absolute;
      top: 0;
      left: 0;
      right: 0;
      bottom: 0;
      background-image: 
        radial-gradient(circle at 20% 50%, rgba(255, 255, 255, 0.1) 0%, transparent 50%),
        radial-gradient(circle at 80% 80%, rgba(255, 255, 255, 0.1) 0%, transparent 50%);
      pointer-events: none;
    }

    /* ==========================================
       GLASS MORPHISM EFFECT
       ========================================== */
    .glass-card {
      background: rgba(255, 255, 255, 0.95);
      backdrop-filter: blur(10px);
      border: 1px solid rgba(255, 255, 255, 0.2);
    }

    /* ==========================================
       HOVER EFFECTS
       ========================================== */
    .hover-lift {
      transition: all 0.4s cubic-bezier(0.175, 0.885, 0.32, 1.275);
    }
    
    .hover-lift:hover {
      transform: translateY(-12px);
      box-shadow: 0 20px 40px rgba(0, 0, 0, 0.2);
    }

    /* ==========================================
       GRADIENT TEXT
       ========================================== */
    .gradient-text {
      background: linear-gradient(135deg, #667eea 0%, #764ba2 100%);
      -webkit-background-clip: text;
      -webkit-text-fill-color: transparent;
      background-clip: text;
    }

    /* ==========================================
       FLOATING WHATSAPP BUTTON
       ========================================== */
    .floating-wa {
      position: fixed;
      bottom: 30px;
      right: 30px;
      z-index: 999;
      animation: float 3s ease-in-out infinite;
    }
    
    @keyframes float {
      0%, 100% { 
        transform: translateY(0px); 
      }
      50% { 
        transform: translateY(-15px); 
      }
    }
    
    .pulse-ring {
      animation: pulse-ring 2s cubic-bezier(0.215, 0.61, 0.355, 1) infinite;
    }
    
    @keyframes pulse-ring {
      0% { 
        transform: scale(1); 
        opacity: 1; 
      }
      100% { 
        transform: scale(1.5); 
        opacity: 0; 
      }
    }

    /* ==========================================
       SERVICE CARD ANIMATIONS
       ========================================== */
    .service-icon {
      transition: transform 0.3s ease;
    }
    
    .service-card:hover .service-icon {
      transform: scale(1.1) rotate(5deg);
    }

    /* ==========================================
       FADE IN ANIMATION
       ========================================== */
    .fade-in {
      animation: fadeIn 0.6s ease-out forwards;
      opacity: 0;
    }
    
    @keyframes fadeIn {
      from { 
        opacity: 0; 
        transform: translateY(30px); 
      }
      to { 
        opacity: 1; 
        transform: translateY(0); 
      }
    }

    /* ==========================================
       BUTTON STYLES
       ========================================== */
    .btn-primary {
      background: linear-gradient(135deg, #667eea 0%, #764ba2 100%);
      transition: all 0.3s ease;
      display: inline-block;
    }
    
    .btn-primary:hover {
      transform: translateY(-2px);
      box-shadow: 0 10px 25px rgba(102, 126, 234, 0.4);
    }

    /* ==========================================
       SECTION DIVIDER
       ========================================== */
    .section-divider {
      position: relative;
      height: 2px;
      background: linear-gradient(90deg, transparent, #667eea, transparent);
      margin: 4rem auto;
      max-width: 200px;
    }

    /* ==========================================
       NAVIGATION STYLES
       ========================================== */
    nav {
      position: fixed;
      width: 100%;
      top: 0;
      z-index: 50;
    }

    nav a {
      transition: color 0.3s ease;
    }

    /* ==========================================
       PORTFOLIO HOVER EFFECTS
       ========================================== */
    .portfolio-item {
      position: relative;
      overflow: hidden;
      border-radius: 1rem;
      height: 20rem;
    }

    .portfolio-overlay {
      position: absolute;
      inset: 0;
      background: rgba(0, 0, 0, 0.6);
      opacity: 0;
      transition: opacity 0.3s ease;
      display: flex;
      align-items: center;
      justify-content: center;
    }

    .portfolio-item:hover .portfolio-overlay {
      opacity: 1;
    }

    /* ==========================================
       CONTACT CARD STYLES
       ========================================== */
    .contact-icon-wrapper {
      width: 3.5rem;
      height: 3.5rem;
      border-radius: 0.75rem;
      display: flex;
      align-items: center;
      justify-content: center;
      flex-shrink: 0;
      box-shadow: 0 4px 6px rgba(0, 0, 0, 0.1);
    }

    /* ==========================================
       STATS SECTION
       ========================================== */
    .stat-number {
      font-size: 2.5rem;
      font-weight: bold;
      margin-bottom: 0.25rem;
    }

    .stat-label {
      color: rgba(216, 180, 254, 1);
      font-size: 0.875rem;
    }

    /* ==========================================
       SERVICE CHECKLIST
       ========================================== */
    .service-checklist {
      list-style: none;
      padding: 0;
      margin: 0;
    }

    .service-checklist li {
      display: flex;
      align-items: center;
      margin-bottom: 0.5rem;
      font-size: 0.875rem;
      color: #4b5563;
    }

    .check-icon {
      width: 1rem;
      height: 1rem;
      color: #10b981;
      margin-right: 0.5rem;
      flex-shrink: 0;
    }

    /* ==========================================
       FOOTER STYLES
       ========================================== */
    footer {
      background: linear-gradient(to bottom right, #111827, #581c87);
    }

    footer h3,
    footer h4 {
      font-weight: bold;
    }

    footer ul {
      list-style: none;
      padding: 0;
      margin: 0;
    }

    footer a {
      transition: color 0.3s ease;
    }

    footer a:hover {
      color: #ffffff;
    }

    /* ==========================================
       BADGE STYLES
       ========================================== */
    .badge {
      display: inline-block;
      padding: 0.5rem 1rem;
      border-radius: 9999px;
      font-weight: 600;
      font-size: 0.875rem;
    }

    .badge-purple {
      background-color: #e9d5ff;
      color: #7c3aed;
    }

    /* ==========================================
       CTA BOX STYLES
       ========================================== */
    .cta-box-bg {
      position: absolute;
      inset: 0;
      background: linear-gradient(to bottom right, #7c3aed, #4f46e5);
      border-radius: 1.5rem;
      transform: rotate(3deg);
    }

    .cta-box-content {
      position: relative;
      padding: 2.5rem;
      border-radius: 1.5rem;
      box-shadow: 0 25px 50px rgba(0, 0, 0, 0.15);
      border: 2px solid #e9d5ff;
    }

    /* ==========================================
       FEATURE GRID
       ========================================== */
    .feature-grid {
      display: grid;
      grid-template-columns: repeat(3, 1fr);
      gap: 1rem;
      padding-top: 1.5rem;
      border-top: 1px solid #e5e7eb;
    }

    .feature-item {
      text-align: center;
    }

    .feature-icon {
      font-size: 1.875rem;
      margin-bottom: 0.25rem;
    }

    .feature-label {
      font-size: 0.75rem;
      color: #4b5563;
      font-weight: 500;
    }

    /* ==========================================
       RESPONSIVE STYLES
       ========================================== */
    @media (max-width: 768px) {
      .hero-bg {
        padding-top: 8rem;
        padding-bottom: 5rem;
      }

      .stat-number {
        font-size: 2rem;
      }

      .floating-wa {
        bottom: 20px;
        right: 20px;
      }

      .floating-wa .wa-button {
        width: 56px;
        height: 56px;
      }

      .floating-wa svg {
        width: 32px;
        height: 32px;
      }

      .section-spacing {
        padding-top: 3rem;
        padding-bottom: 3rem;
      }
    }

    @media (max-width: 640px) {
      .feature-grid {
        grid-template-columns: repeat(3, 1fr);
        gap: 0.75rem;
      }

      .portfolio-item {
        height: 16rem;
      }
    }

    /* ==========================================
       UTILITY CLASSES
       ========================================== */
    .w-full {
      width: 100%;
    }

    .h-full {
      height: 100%;
    }

    .relative {
      position: relative;
    }

    .absolute {
      position: absolute;
    }

    .inset-0 {
      top: 0;
      right: 0;
      bottom: 0;
      left: 0;
    }

    .flex {
      display: flex;
    }

    .items-center {
      align-items: center;
    }

    .justify-center {
      justify-content: center;
    }

    .text-center {
      text-align: center;
    }

    .rounded-full {
      border-radius: 9999px;
    }

    .shadow-lg {
      box-shadow: 0 10px 15px rgba(0, 0, 0, 0.1);
    }

    .shadow-xl {
      box-shadow: 0 20px 25px rgba(0, 0, 0, 0.15);
    }

    .shadow-2xl {
      box-shadow: 0 25px 50px rgba(0, 0, 0, 0.25);
    }

    /* ==========================================
       MOBILE MENU
       ========================================== */
    #mobile-menu {
      transition: all 0.3s ease;
    }

    #mobile-menu.hidden {
      display: none;
    }

    /* ==========================================
       HERO PREVIEW CARDS
       ========================================== */
    .hero-preview-card {
      padding: 1rem;
      border-radius: 0.75rem;
    }

    .hero-preview-icon {
      width: 4rem;
      height: 4rem;
      border-radius: 0.5rem;
      display: flex;
      align-items: center;
      justify-content: center;
    }

    /* ==========================================
       GRADIENT BACKGROUNDS
       ========================================== */
    .gradient-pink-purple {
      background: linear-gradient(to right, #fce7f3, #f3e8ff);
    }

    .gradient-blue-cyan {
      background: linear-gradient(to right, #dbeafe, #cffafe);
    }

    .gradient-orange-yellow {
      background: linear-gradient(to right, #fed7aa, #fef3c7);
    }

    .gradient-green-emerald {
      background: linear-gradient(to bottom right, #10b981, #059669);
    }

    .gradient-blue-cyan-solid {
      background: linear-gradient(to bottom right, #3b82f6, #06b6d4);
    }

    .gradient-orange-yellow-solid {
      background: linear-gradient(to bottom right, #f97316, #eab308);
    }

    .gradient-purple-indigo {
      background: linear-gradient(to bottom right, #a855f7, #6366f1);
    }

    .gradient-red-rose {
      background: linear-gradient(to bottom right, #ef4444, #f43f5e);
    }

    .gradient-pink-rose {
      background: linear-gradient(to bottom right, #ec4899, #f43f5e);
    }

    /* ==========================================
       PORTFOLIO SECTION BACKGROUND
       ========================================== */
    .portfolio-bg {
      background: linear-gradient(to bottom right, #faf5ff, #fce7f3);
    }
  </style>
  <style>@view-transition { navigation: auto; }</style>
  <script src="/_sdk/data_sdk.js" type="text/javascript"></script>
 </head>
 <body class="h-full overflow-auto bg-gray-50">
  <div id="app" class="w-full min-h-full"><!-- Floating WhatsApp Button --> <a href="https://wa.me/6285815056990" target="_blank" rel="noopener noreferrer" class="floating-wa group">
    <div class="relative">
     <div class="absolute inset-0 bg-green-500 rounded-full pulse-ring"></div>
     <div class="relative bg-green-500 w-16 h-16 rounded-full flex items-center justify-center shadow-2xl group-hover:bg-green-600 transition wa-button">
      <svg class="w-9 h-9 text-white" fill="currentColor" viewbox="0 0 24 24"><path d="M17.472 14.382c-.297-.149-1.758-.867-2.03-.967-.273-.099-.471-.148-.67.15-.197.297-.767.966-.94 1.164-.173.199-.347.223-.644.075-.297-.15-1.255-.463-2.39-1.475-.883-.788-1.48-1.761-1.653-2.059-.173-.297-.018-.458.13-.606.134-.133.298-.347.446-.52.149-.174.198-.298.298-.497.099-.198.05-.371-.025-.52-.075-.149-.669-1.612-.916-2.207-.242-.579-.487-.5-.669-.51-.173-.008-.371-.01-.57-.01-.198 0-.52.074-.792.372-.272.297-1.04 1.016-1.04 2.479 0 1.462 1.065 2.875 1.213 3.074.149.198 2.096 3.2 5.077 4.487.709.306 1.262.489 1.694.625.712.227 1.36.195 1.871.118.571-.085 1.758-.719 2.006-1.413.248-.694.248-1.289.173-1.413-.074-.124-.272-.198-.57-.347m-5.421 7.403h-.004a9.87 9.87 0 01-5.031-1.378l-.361-.214-3.741.982.998-3.648-.235-.374a9.86 9.86 0 01-1.51-5.26c.001-5.45 4.436-9.884 9.888-9.884 2.64 0 5.122 1.03 6.988 2.898a9.825 9.825 0 012.893 6.994c-.003 5.45-4.437 9.884-9.885 9.884m8.413-18.297A11.815 11.815 0 0012.05 0C5.495 0 .16 5.335.157 11.892c0 2.096.547 4.142 1.588 5.945L.057 24l6.305-1.654a11.882 11.882 0 005.683 1.448h.005c6.554 0 11.89-5.335 11.893-11.893a11.821 11.821 0 00-3.48-8.413z" />
      </svg>
     </div>
    </div></a> <!-- Navigation -->
   <nav class="glass-card shadow-md">
    <div class="max-w-7xl mx-auto px-6 lg:px-8">
     <div class="flex justify-between items-center h-20">
      <div class="flex items-center space-x-3">
       <div class="w-12 h-12 bg-gradient-to-br from-purple-600 to-indigo-600 rounded-xl flex items-center justify-center shadow-lg"><span class="text-white font-bold text-2xl">A</span>
       </div>
       <div>
        <h1 id="nav-brand" class="text-xl font-bold gradient-text">Awalan Design.id</h1>
        <p id="nav-tagline" class="text-xs text-gray-600">Studio Desain Grafis UMKM</p>
       </div>
      </div>
      <div class="hidden md:flex items-center space-x-8"><a href="#home" class="text-gray-700 hover:text-purple-600 font-medium transition">Beranda</a> <a href="#services" class="text-gray-700 hover:text-purple-600 font-medium transition">Layanan</a> <a href="#portfolio" class="text-gray-700 hover:text-purple-600 font-medium transition">Portofolio</a> <a href="#contact" class="text-gray-700 hover:text-purple-600 font-medium transition">Kontak</a> <a href="https://wa.me/6285815056990" target="_blank" rel="noopener noreferrer" class="btn-primary text-white px-6 py-2.5 rounded-lg font-semibold shadow-lg"> Chat Sekarang </a>
      </div><!-- Mobile menu button --> <button class="md:hidden p-2" onclick="toggleMobileMenu()">
       <svg class="w-6 h-6 text-gray-700" fill="none" stroke="currentColor" viewbox="0 0 24 24"><path stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M4 6h16M4 12h16M4 18h16" />
       </svg></button>
     </div>
    </div><!-- Mobile menu -->
    <div id="mobile-menu" class="hidden md:hidden border-t border-gray-200">
     <div class="px-6 py-4 space-y-3"><a href="#home" class="block text-gray-700 hover:text-purple-600 font-medium">Beranda</a> <a href="#services" class="block text-gray-700 hover:text-purple-600 font-medium">Layanan</a> <a href="#portfolio" class="block text-gray-700 hover:text-purple-600 font-medium">Portofolio</a> <a href="#contact" class="block text-gray-700 hover:text-purple-600 font-medium">Kontak</a> <a href="https://wa.me/6285815056990" target="_blank" rel="noopener noreferrer" class="block btn-primary text-white px-6 py-2.5 rounded-lg font-semibold text-center"> Chat Sekarang </a>
     </div>
    </div>
   </nav><!-- Hero Section -->
   <section id="home" class="hero-bg pt-32 pb-20 px-6 lg:px-8 fade-in">
    <div class="max-w-7xl mx-auto">
     <div class="grid lg:grid-cols-2 gap-12 items-center">
      <div class="text-white">
       <div class="badge badge-purple mb-6"><span class="text-sm font-semibold">✨ Jasa Desain Grafis Terpercaya</span>
       </div>
       <h1 id="hero-title" class="text-5xl lg:text-6xl font-display font-bold mb-6 leading-tight">Wujudkan Brand Impian Anda</h1>
       <p id="hero-subtitle" class="text-xl lg:text-2xl mb-8 text-purple-100 leading-relaxed">Desain Grafis Profesional untuk UMKM Indonesia</p>
       <div class="flex flex-col sm:flex-row gap-4"><a href="https://wa.me/6285815056990" target="_blank" rel="noopener noreferrer" class="inline-flex items-center justify-center bg-white text-purple-600 px-8 py-4 rounded-lg font-bold text-lg hover:bg-gray-50 transition shadow-2xl">
         <svg class="w-6 h-6 mr-2" fill="currentColor" viewbox="0 0 24 24"><path d="M17.472 14.382c-.297-.149-1.758-.867-2.03-.967-.273-.099-.471-.148-.67.15-.197.297-.767.966-.94 1.164-.173.199-.347.223-.644.075-.297-.15-1.255-.463-2.39-1.475-.883-.788-1.48-1.761-1.653-2.059-.173-.297-.018-.458.13-.606.134-.133.298-.347.446-.52.149-.174.198-.298.298-.497.099-.198.05-.371-.025-.52-.075-.149-.669-1.612-.916-2.207-.242-.579-.487-.5-.669-.51-.173-.008-.371-.01-.57-.01-.198 0-.52.074-.792.372-.272.297-1.04 1.016-1.04 2.479 0 1.462 1.065 2.875 1.213 3.074.149.198 2.096 3.2 5.077 4.487.709.306 1.262.489 1.694.625.712.227 1.36.195 1.871.118.571-.085 1.758-.719 2.006-1.413.248-.694.248-1.289.173-1.413-.074-.124-.272-.198-.57-.347m-5.421 7.403h-.004a9.87 9.87 0 01-5.031-1.378l-.361-.214-3.741.982.998-3.648-.235-.374a9.86 9.86 0 01-1.51-5.26c.001-5.45 4.436-9.884 9.888-9.884 2.64 0 5.122 1.03 6.988 2.898a9.825 9.825 0 012.893 6.994c-.003 5.45-4.437 9.884-9.885 9.884m8.413-18.297A11.815 11.815 0 0012.05 0C5.495 0 .16 5.335.157 11.892c0 2.096.547 4.142 1.588 5.945L.057 24l6.305-1.654a11.882 11.882 0 005.683 1.448h.005c6.554 0 11.89-5.335 11.893-11.893a11.821 11.821 0 00-3.48-8.413z" />
         </svg><span id="cta-button">Konsultasi Gratis</span> </a> <a href="#portfolio" class="inline-flex items-center justify-center bg-transparent border-2 border-white text-white px-8 py-4 rounded-lg font-bold text-lg hover:bg-white hover:text-purple-600 transition">
         <svg class="w-6 h-6 mr-2" fill="none" stroke="currentColor" viewbox="0 0 24 24"><path stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M15 12a3 3 0 11-6 0 3 3 0 016 0z" /> <path stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M2.458 12C3.732 7.943 7.523 5 12 5c4.478 0 8.268 2.943 9.542 7-1.274 4.057-5.064 7-9.542 7-4.477 0-8.268-2.943-9.542-7z" />
         </svg> Lihat Portofolio </a>
       </div><!-- Stats -->
       <div class="grid grid-cols-3 gap-6 mt-12">
        <div>
         <div class="stat-number">
          100+
         </div>
         <div class="stat-label">
          Klien Puas
         </div>
        </div>
        <div>
         <div class="stat-number">
          500+
         </div>
         <div class="stat-label">
          Proyek Selesai
         </div>
        </div>
        <div>
         <div class="stat-number">
          5★
         </div>
         <div class="stat-label">
          Rating Klien
         </div>
        </div>
       </div>
      </div>
      <div class="hidden lg:block">
       <div class="relative">
        <div class="absolute inset-0 bg-white/10 backdrop-blur-sm rounded-3xl transform rotate-6"></div>
        <div class="relative glass-card p-8 rounded-3xl shadow-2xl overflow-hidden"><!-- Hero Image Illustration -->
         <div class="mb-8">
          <svg viewbox="0 0 400 300" class="w-full h-auto rounded-2xl"><!-- Background --> <rect width="400" height="300" fill="url(#heroGradient)" /> <defs>
            <lineargradient id="heroGradient" x1="0%" y1="0%" x2="100%" y2="100%">
             <stop offset="0%" style="stop-color:#667eea;stop-opacity:1" />
             <stop offset="100%" style="stop-color:#764ba2;stop-opacity:1" />
            </lineargradient>
           </defs> <!-- Desktop Computer --> <rect x="80" y="80" width="240" height="160" rx="8" fill="#ffffff" opacity="0.95" /> <rect x="90" y="90" width="220" height="120" fill="#f3f4f6" /> <!-- Screen Content - Design Elements --> <rect x="110" y="105" width="60" height="60" rx="4" fill="#fce7f3" /> <rect x="180" y="105" width="110" height="25" rx="4" fill="#e9d5ff" /> <rect x="180" y="140" width="110" height="25" rx="4" fill="#dbeafe" /> <circle cx="140" cy="135" r="18" fill="#ec4899" /> <!-- Laptop Base --> <path d="M60 240 L340 240 L320 255 L80 255 Z" fill="#e5e7eb" /> <rect x="180" y="252" width="40" height="3" rx="1.5" fill="#9ca3af" /> <!-- Floating Design Elements --> <circle cx="330" cy="100" r="25" fill="#fbbf24" opacity="0.7">
            <animatetransform attributename="transform" type="translate" values="0,0; 0,-10; 0,0" dur="3s" repeatcount="indefinite" />
           </circle> <rect x="50" y="180" width="35" height="35" rx="6" fill="#10b981" opacity="0.7">
            <animatetransform attributename="transform" type="translate" values="0,0; 0,10; 0,0" dur="4s" repeatcount="indefinite" />
           </rect> <polygon points="340,200 355,230 325,230" fill="#3b82f6" opacity="0.7">
            <animatetransform attributename="transform" type="translate" values="0,0; 0,-8; 0,0" dur="3.5s" repeatcount="indefinite" />
           </polygon> <!-- Sparkles --> <circle cx="100" cy="60" r="3" fill="#fbbf24">
            <animate attributename="opacity" values="1;0.3;1" dur="2s" repeatcount="indefinite" />
           </circle> <circle cx="310" cy="270" r="3" fill="#ec4899">
            <animate attributename="opacity" values="0.3;1;0.3" dur="2.5s" repeatcount="indefinite" />
           </circle> <circle cx="70" cy="120" r="2" fill="#10b981">
            <animate attributename="opacity" values="1;0.3;1" dur="3s" repeatcount="indefinite" />
           </circle>
          </svg>
         </div>
         <div class="space-y-4">
          <div class="hero-preview-card gradient-pink-purple flex items-center space-x-4">
           <div class="hero-preview-icon gradient-pink-rose">
            <svg class="w-8 h-8 text-white" fill="none" stroke="currentColor" viewbox="0 0 24 24"><path stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M7 21a4 4 0 01-4-4V5a2 2 0 012-2h4a2 2 0 012 2v12a4 4 0 01-4 4zm0 0h12a2 2 0 002-2v-4a2 2 0 00-2-2h-2.343M11 7.343l1.657-1.657a2 2 0 012.828 0l2.829 2.829a2 2 0 010 2.828l-8.486 8.485M7 17h.01" />
            </svg>
           </div>
           <div>
            <h3 class="font-bold text-gray-800">Logo Design</h3>
            <p class="text-sm text-gray-600">Brand Identity</p>
           </div>
          </div>
          <div class="hero-preview-card gradient-blue-cyan flex items-center space-x-4">
           <div class="hero-preview-icon gradient-blue-cyan-solid">
            <svg class="w-8 h-8 text-white" fill="none" stroke="currentColor" viewbox="0 0 24 24"><path stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M4 16l4.586-4.586a2 2 0 012.828 0L16 16m-2-2l1.586-1.586a2 2 0 012.828 0L20 14m-6-6h.01M6 20h12a2 2 0 002-2V6a2 2 0 00-2-2H6a2 2 0 00-2 2v12a2 2 0 002 2z" />
            </svg>
           </div>
           <div>
            <h3 class="font-bold text-gray-800">Social Media</h3>
            <p class="text-sm text-gray-600">Content Design</p>
           </div>
          </div>
          <div class="hero-preview-card gradient-orange-yellow flex items-center space-x-4">
           <div class="hero-preview-icon gradient-orange-yellow-solid">
            <svg class="w-8 h-8 text-white" fill="none" stroke="currentColor" viewbox="0 0 24 24"><path stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M19 11H5m14 0a2 2 0 012 2v6a2 2 0 01-2 2H5a2 2 0 01-2-2v-6a2 2 0 012-2m14 0V9a2 2 0 00-2-2M5 11V9a2 2 0 012-2m0 0V5a2 2 0 012-2h6a2 2 0 012 2v2M7 7h10" />
            </svg>
           </div>
           <div>
            <h3 class="font-bold text-gray-800">Packaging</h3>
            <p class="text-sm text-gray-600">Product Design</p>
           </div>
          </div>
         </div>
        </div>
       </div>
      </div>
     </div>
    </div>
   </section><!-- Services Section -->
   <section id="services" class="py-20 px-6 lg:px-8 fade-in section-spacing">
    <div class="max-w-7xl mx-auto">
     <div class="text-center mb-16"><span class="badge badge-purple mb-4"> 💼 Layanan Kami </span>
      <h2 id="services-title" class="text-4xl lg:text-5xl font-display font-bold mb-4 gradient-text">Layanan Kami</h2>
      <p id="services-subtitle" class="text-xl text-gray-600 max-w-2xl mx-auto">Solusi desain lengkap untuk bisnis UMKM</p>
     </div>
     <div class="grid md:grid-cols-2 lg:grid-cols-3 gap-8"><!-- Service 1 -->
      <div class="service-card glass-card p-8 rounded-2xl shadow-lg hover-lift">
       <div class="service-icon w-16 h-16 gradient-pink-rose rounded-xl flex items-center justify-center mb-6">
        <svg class="w-8 h-8 text-white" fill="none" stroke="currentColor" viewbox="0 0 24 24"><path stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M7 21a4 4 0 01-4-4V5a2 2 0 012-2h4a2 2 0 012 2v12a4 4 0 01-4 4zm0 0h12a2 2 0 002-2v-4a2 2 0 00-2-2h-2.343M11 7.343l1.657-1.657a2 2 0 012.828 0l2.829 2.829a2 2 0 010 2.828l-8.486 8.485M7 17h.01" />
        </svg>
       </div>
       <h3 class="text-2xl font-bold mb-3 text-gray-800">Logo &amp; Brand Identity</h3>
       <p class="text-gray-600 mb-4">Desain logo unik dan memorable yang merepresentasikan brand UMKM Anda dengan sempurna</p>
       <ul class="service-checklist">
        <li>
         <svg class="check-icon" fill="currentColor" viewbox="0 0 20 20"><path fill-rule="evenodd" d="M16.707 5.293a1 1 0 010 1.414l-8 8a1 1 0 01-1.414 0l-4-4a1 1 0 011.414-1.414L8 12.586l7.293-7.293a1 1 0 011.414 0z" clip-rule="evenodd" />
         </svg> Logo Modern &amp; Minimalis</li>
        <li>
         <svg class="check-icon" fill="currentColor" viewbox="0 0 20 20"><path fill-rule="evenodd" d="M16.707 5.293a1 1 0 010 1.414l-8 8a1 1 0 01-1.414 0l-4-4a1 1 0 011.414-1.414L8 12.586l7.293-7.293a1 1 0 011.414 0z" clip-rule="evenodd" />
         </svg> Brand Guidelines Lengkap</li>
        <li>
         <svg class="check-icon" fill="currentColor" viewbox="0 0 20 20"><path fill-rule="evenodd" d="M16.707 5.293a1 1 0 010 1.414l-8 8a1 1 0 01-1.414 0l-4-4a1 1 0 011.414-1.414L8 12.586l7.293-7.293a1 1 0 011.414 0z" clip-rule="evenodd" />
         </svg> Revisi Unlimited</li>
       </ul>
      </div><!-- Service 2 -->
      <div class="service-card glass-card p-8 rounded-2xl shadow-lg hover-lift">
       <div class="service-icon w-16 h-16 gradient-blue-cyan-solid rounded-xl flex items-center justify-center mb-6">
        <svg class="w-8 h-8 text-white" fill="none" stroke="currentColor" viewbox="0 0 24 24"><path stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M4 16l4.586-4.586a2 2 0 012.828 0L16 16m-2-2l1.586-1.586a2 2 0 012.828 0L20 14m-6-6h.01M6 20h12a2 2 0 002-2V6a2 2 0 00-2-2H6a2 2 0 00-2 2v12a2 2 0 002 2z" />
        </svg>
       </div>
       <h3 class="text-2xl font-bold mb-3 text-gray-800">Social Media Design</h3>
       <p class="text-gray-600 mb-4">Konten visual menarik untuk Instagram, Facebook, dan platform media sosial lainnya</p>
       <ul class="service-checklist">
        <li>
         <svg class="check-icon" fill="currentColor" viewbox="0 0 20 20"><path fill-rule="evenodd" d="M16.707 5.293a1 1 0 010 1.414l-8 8a1 1 0 01-1.414 0l-4-4a1 1 0 011.414-1.414L8 12.586l7.293-7.293a1 1 0 011.414 0z" clip-rule="evenodd" />
         </svg> Instagram Feed &amp; Story</li>
        <li>
         <svg class="check-icon" fill="currentColor" viewbox="0 0 20 20"><path fill-rule="evenodd" d="M16.707 5.293a1 1 0 010 1.414l-8 8a1 1 0 01-1.414 0l-4-4a1 1 0 011.414-1.414L8 12.586l7.293-7.293a1 1 0 011.414 0z" clip-rule="evenodd" />
         </svg> Facebook Post Design</li>
        <li>
         <svg class="check-icon" fill="currentColor" viewbox="0 0 20 20"><path fill-rule="evenodd" d="M16.707 5.293a1 1 0 010 1.414l-8 8a1 1 0 01-1.414 0l-4-4a1 1 0 011.414-1.414L8 12.586l7.293-7.293a1 1 0 011.414 0z" clip-rule="evenodd" />
         </svg> Template Editable</li>
       </ul>
      </div><!-- Service 3 -->
      <div class="service-card glass-card p-8 rounded-2xl shadow-lg hover-lift">
       <div class="service-icon w-16 h-16 gradient-orange-yellow-solid rounded-xl flex items-center justify-center mb-6">
        <svg class="w-8 h-8 text-white" fill="none" stroke="currentColor" viewbox="0 0 24 24"><path stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M19 11H5m14 0a2 2 0 012 2v6a2 2 0 01-2 2H5a2 2 0 01-2-2v-6a2 2 0 012-2m14 0V9a2 2 0 00-2-2M5 11V9a2 2 0 012-2m0 0V5a2 2 0 012-2h6a2 2 0 012 2v2M7 7h10" />
        </svg>
       </div>
       <h3 class="text-2xl font-bold mb-3 text-gray-800">Packaging Design</h3>
       <p class="text-gray-600 mb-4">Desain kemasan produk yang eye-catching dan meningkatkan nilai jual produk UMKM</p>
       <ul class="service-checklist">
        <li>
         <svg class="check-icon" fill="currentColor" viewbox="0 0 20 20"><path fill-rule="evenodd" d="M16.707 5.293a1 1 0 010 1.414l-8 8a1 1 0 01-1.414 0l-4-4a1 1 0 011.414-1.414L8 12.586l7.293-7.293a1 1 0 011.414 0z" clip-rule="evenodd" />
         </svg> Box &amp; Pouch Design</li>
        <li>
         <svg class="check-icon" fill="currentColor" viewbox="0 0 20 20"><path fill-rule="evenodd" d="M16.707 5.293a1 1 0 010 1.414l-8 8a1 1 0 01-1.414 0l-4-4a1 1 0 011.414-1.414L8 12.586l7.293-7.293a1 1 0 011.414 0z" clip-rule="evenodd" />
         </svg> Label Produk Premium</li>
        <li>
         <svg class="check-icon" fill="currentColor" viewbox="0 0 20 20"><path fill-rule="evenodd" d="M16.707 5.293a1 1 0 010 1.414l-8 8a1 1 0 01-1.414 0l-4-4a1 1 0 011.414-1.414L8 12.586l7.293-7.293a1 1 0 011.414 0z" clip-rule="evenodd" />
         </svg> Print-Ready File</li>
       </ul>
      </div><!-- Service 4 -->
      <div class="service-card glass-card p-8 rounded-2xl shadow-lg hover-lift">
       <div class="service-icon w-16 h-16 gradient-green-emerald rounded-xl flex items-center justify-center mb-6">
        <svg class="w-8 h-8 text-white" fill="none" stroke="currentColor" viewbox="0 0 24 24"><path stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M9 12h6m-6 4h6m2 5H7a2 2 0 01-2-2V5a2 2 0 012-2h5.586a1 1 0 01.707.293l5.414 5.414a1 1 0 01.293.707V19a2 2 0 01-2 2z" />
        </svg>
       </div>
       <h3 class="text-2xl font-bold mb-3 text-gray-800">Flyer &amp; Brochure</h3>
       <p class="text-gray-600 mb-4">Materi promosi yang efektif untuk campaign marketing dan branding bisnis Anda</p>
       <ul class="service-checklist">
        <li>
         <svg class="check-icon" fill="currentColor" viewbox="0 0 20 20"><path fill-rule="evenodd" d="M16.707 5.293a1 1 0 010 1.414l-8 8a1 1 0 01-1.414 0l-4-4a1 1 0 011.414-1.414L8 12.586l7.293-7.293a1 1 0 011.414 0z" clip-rule="evenodd" />
         </svg> Flyer A5 &amp; A4</li>
        <li>
         <svg class="check-icon" fill="currentColor" viewbox="0 0 20 20"><path fill-rule="evenodd" d="M16.707 5.293a1 1 0 010 1.414l-8 8a1 1 0 01-1.414 0l-4-4a1 1 0 011.414-1.414L8 12.586l7.293-7.293a1 1 0 011.414 0z" clip-rule="evenodd" />
         </svg> Brosur Multi-Page</li>
        <li>
         <svg class="check-icon" fill="currentColor" viewbox="0 0 20 20"><path fill-rule="evenodd" d="M16.707 5.293a1 1 0 010 1.414l-8 8a1 1 0 01-1.414 0l-4-4a1 1 0 011.414-1.414L8 12.586l7.293-7.293a1 1 0 011.414 0z" clip-rule="evenodd" />
         </svg> High Resolution</li>
       </ul>
      </div><!-- Service 5 -->
      <div class="service-card glass-card p-8 rounded-2xl shadow-lg hover-lift">
       <div class="service-icon w-16 h-16 gradient-purple-indigo rounded-xl flex items-center justify-center mb-6">
        <svg class="w-8 h-8 text-white" fill="none" stroke="currentColor" viewbox="0 0 24 24"><path stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M7 21h10a2 2 0 002-2V9.414a1 1 0 00-.293-.707l-5.414-5.414A1 1 0 0012.586 3H7a2 2 0 00-2 2v14a2 2 0 002 2z" />
        </svg>
       </div>
       <h3 class="text-2xl font-bold mb-3 text-gray-800">Banner &amp; Signage</h3>
       <p class="text-gray-600 mb-4">Desain banner dan papan nama toko yang profesional dan menarik perhatian</p>
       <ul class="service-checklist">
        <li>
         <svg class="check-icon" fill="currentColor" viewbox="0 0 20 20"><path fill-rule="evenodd" d="M16.707 5.293a1 1 0 010 1.414l-8 8a1 1 0 01-1.414 0l-4-4a1 1 0 011.414-1.414L8 12.586l7.293-7.293a1 1 0 011.414 0z" clip-rule="evenodd" />
         </svg> X-Banner &amp; Roll Banner</li>
        <li>
         <svg class="check-icon" fill="currentColor" viewbox="0 0 20 20"><path fill-rule="evenodd" d="M16.707 5.293a1 1 0 010 1.414l-8 8a1 1 0 01-1.414 0l-4-4a1 1 0 011.414-1.414L8 12.586l7.293-7.293a1 1 0 011.414 0z" clip-rule="evenodd" />
         </svg> Neon Box Design</li>
        <li>
         <svg class="check-icon" fill="currentColor" viewbox="0 0 20 20"><path fill-rule="evenodd" d="M16.707 5.293a1 1 0 010 1.414l-8 8a1 1 0 01-1.414 0l-4-4a1 1 0 011.414-1.414L8 12.586l7.293-7.293a1 1 0 011.414 0z" clip-rule="evenodd" />
         </svg> Custom Size</li>
       </ul>
      </div><!-- Service 6 -->
      <div class="service-card glass-card p-8 rounded-2xl shadow-lg hover-lift">
       <div class="service-icon w-16 h-16 gradient-red-rose rounded-xl flex items-center justify-center mb-6">
        <svg class="w-8 h-8 text-white" fill="none" stroke="currentColor" viewbox="0 0 24 24"><path stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M7 7h.01M7 3h5c.512 0 1.024.195 1.414.586l7 7a2 2 0 010 2.828l-7 7a2 2 0 01-2.828 0l-7-7A1.994 1.994 0 013 12V7a4 4 0 014-4z" />
        </svg>
       </div>
       <h3 class="text-2xl font-bold mb-3 text-gray-800">Sticker &amp; Label</h3>
       <p class="text-gray-600 mb-4">Desain sticker dan label produk yang menarik dan berkualitas tinggi</p>
       <ul class="service-checklist">
        <li>
         <svg class="check-icon" fill="currentColor" viewbox="0 0 20 20"><path fill-rule="evenodd" d="M16.707 5.293a1 1 0 010 1.414l-8 8a1 1 0 01-1.414 0l-4-4a1 1 0 011.414-1.414L8 12.586l7.293-7.293a1 1 0 011.414 0z" clip-rule="evenodd" />
         </svg> Sticker Custom Shape</li>
        <li>
         <svg class="check-icon" fill="currentColor" viewbox="0 0 20 20"><path fill-rule="evenodd" d="M16.707 5.293a1 1 0 010 1.414l-8 8a1 1 0 01-1.414 0l-4-4a1 1 0 011.414-1.414L8 12.586l7.293-7.293a1 1 0 011.414 0z" clip-rule="evenodd" />
         </svg> Label Premium</li>
        <li>
         <svg class="check-icon" fill="currentColor" viewbox="0 0 20 20"><path fill-rule="evenodd" d="M16.707 5.293a1 1 0 010 1.414l-8 8a1 1 0 01-1.414 0l-4-4a1 1 0 011.414-1.414L8 12.586l7.293-7.293a1 1 0 011.414 0z" clip-rule="evenodd" />
         </svg> Die-Cut Ready</li>
       </ul>
      </div>
     </div>
    </div>
   </section><!-- Portfolio Section -->
   <section id="portfolio" class="py-20 px-6 lg:px-8 portfolio-bg fade-in section-spacing">
    <div class="max-w-7xl mx-auto">
     <div class="text-center mb-16"><span class="badge badge-purple mb-4"> 🎨 Portofolio Kami </span>
      <h2 class="text-4xl lg:text-5xl font-display font-bold mb-4 gradient-text">Karya Terbaik Kami</h2>
      <p class="text-xl text-gray-600 max-w-2xl mx-auto">Lihat koleksi desain grafis berkualitas tinggi yang telah kami kerjakan untuk klien UMKM</p>
     </div>
     <div class="grid md:grid-cols-2 lg:grid-cols-3 gap-8 mb-12"><!-- Logo Design Portfolio -->
      <div class="portfolio-item group shadow-xl hover-lift">
       <svg viewbox="0 0 400 320" class="w-full h-full"><rect width="400" height="320" fill="url(#logoGradient)" /> <defs>
         <lineargradient id="logoGradient" x1="0%" y1="0%" x2="100%" y2="100%">
          <stop offset="0%" style="stop-color:#ec4899;stop-opacity:1" />
          <stop offset="100%" style="stop-color:#f43f5e;stop-opacity:1" />
         </lineargradient>
        </defs> <!-- Logo Mockup 1 --> <g transform="translate(50, 50)">
         <circle cx="50" cy="50" r="45" fill="white" opacity="0.95" />
         <path d="M35 40 L50 60 L65 40 Z" fill="#ec4899" />
         <circle cx="50" cy="35" r="8" fill="#f43f5e" />
        </g> <!-- Logo Mockup 2 --> <g transform="translate(200, 50)">
         <rect x="10" y="10" width="80" height="80" rx="12" fill="white" opacity="0.95" />
         <text x="50" y="55" font-family="Arial, sans-serif" font-size="32" font-weight="bold" fill="#ec4899" text-anchor="middle">
          AD
         </text>
        </g> <!-- Logo Mockup 3 --> <g transform="translate(120, 180)">
         <ellipse cx="80" cy="40" rx="75" ry="35" fill="white" opacity="0.95" />
         <rect x="55" y="28" width="50" height="8" rx="4" fill="#ec4899" />
         <circle cx="50" cy="32" r="6" fill="#f43f5e" />
         <circle cx="110" cy="32" r="6" fill="#f43f5e" />
        </g> <!-- Decorative Elements --> <circle cx="350" cy="280" r="20" fill="white" opacity="0.3" /> <circle cx="30" cy="250" r="15" fill="white" opacity="0.3" /> <!-- Title Overlay --> <rect x="0" y="230" width="400" height="90" fill="rgba(0,0,0,0.6)" /> <text x="200" y="270" font-family="Poppins, sans-serif" font-size="28" font-weight="bold" fill="white" text-anchor="middle">
         Logo Design
        </text> <text x="200" y="295" font-family="Poppins, sans-serif" font-size="14" fill="white" text-anchor="middle" opacity="0.9">
         Brand Identity Projects
        </text>
       </svg>
       <div class="portfolio-overlay"><a href="https://drive.google.com/drive/folders/1FjXzKSZ8S1TunF7wx2FQMCrdFnfwrlW_?usp=sharing" target="_blank" rel="noopener noreferrer" class="bg-white text-pink-600 px-6 py-3 rounded-lg font-bold hover:bg-pink-50 transition"> Lihat Detail </a>
       </div>
      </div><!-- Social Media Portfolio -->
      <div class="portfolio-item group shadow-xl hover-lift">
       <svg viewbox="0 0 400 320" class="w-full h-full"><rect width="400" height="320" fill="url(#socialGradient)" /> <defs>
         <lineargradient id="socialGradient" x1="0%" y1="0%" x2="100%" y2="100%">
          <stop offset="0%" style="stop-color:#3b82f6;stop-opacity:1" />
          <stop offset="100%" style="stop-color:#06b6d4;stop-opacity:1" />
         </lineargradient>
        </defs> <!-- Phone Mockup 1 --> <rect x="50" y="40" width="120" height="220" rx="12" fill="white" opacity="0.95" /> <rect x="60" y="55" width="100" height="100" rx="6" fill="#dbeafe" /> <rect x="60" y="165" width="100" height="8" rx="4" fill="#e0e7ff" /> <rect x="60" y="180" width="75" height="8" rx="4" fill="#e0e7ff" /> <circle cx="95" cy="205" r="5" fill="#3b82f6" /> <circle cx="110" cy="205" r="5" fill="#06b6d4" /> <circle cx="125" cy="205" r="5" fill="#8b5cf6" /> <!-- Post Card --> <rect x="200" y="40" width="150" height="180" rx="12" fill="white" opacity="0.95" /> <rect x="210" y="50" width="130" height="100" rx="8" fill="#bfdbfe" /> <rect x="210" y="160" width="130" height="10" rx="5" fill="#dbeafe" /> <rect x="210" y="180" width="100" height="10" rx="5" fill="#dbeafe" /> <circle cx="225" cy="208" r="10" fill="#3b82f6" /> <rect x="240" y="200" width="60" height="8" rx="4" fill="#e0e7ff" /> <!-- Floating Icons --> <g opacity="0.7">
         <circle cx="180" cy="250" r="15" fill="white" />
         <path d="M175 250 L180 255 L185 245" stroke="#3b82f6" stroke-width="2" fill="none" />
        </g> <g opacity="0.7">
         <circle cx="370" cy="80" r="12" fill="white" />
         <circle cx="370" cy="80" r="5" fill="#ec4899" />
        </g> <!-- Title Overlay --> <rect x="0" y="230" width="400" height="90" fill="rgba(0,0,0,0.6)" /> <text x="200" y="270" font-family="Poppins, sans-serif" font-size="28" font-weight="bold" fill="white" text-anchor="middle">
         Social Media
        </text> <text x="200" y="295" font-family="Poppins, sans-serif" font-size="14" fill="white" text-anchor="middle" opacity="0.9">
         Instagram &amp; Facebook Design
        </text>
       </svg>
       <div class="portfolio-overlay"><a href="https://drive.google.com/drive/folders/1FjXzKSZ8S1TunF7wx2FQMCrdFnfwrlW_?usp=sharing" target="_blank" rel="noopener noreferrer" class="bg-white text-blue-600 px-6 py-3 rounded-lg font-bold hover:bg-blue-50 transition"> Lihat Detail </a>
       </div>
      </div><!-- Packaging Portfolio -->
      <div class="portfolio-item group shadow-xl hover-lift">
       <svg viewbox="0 0 400 320" class="w-full h-full"><rect width="400" height="320" fill="url(#packagingGradient)" /> <defs>
         <lineargradient id="packagingGradient" x1="0%" y1="0%" x2="100%" y2="100%">
          <stop offset="0%" style="stop-color:#f97316;stop-opacity:1" />
          <stop offset="100%" style="stop-color:#eab308;stop-opacity:1" />
         </lineargradient>
        </defs> <!-- Box 1 - Front View --> <g transform="translate(50, 60)">
         <path d="M0 0 L80 0 L80 120 L0 120 Z" fill="white" opacity="0.95" />
         <rect x="10" y="15" width="60" height="60" rx="8" fill="#fed7aa" />
         <circle cx="40" cy="45" r="15" fill="#f97316" />
         <rect x="10" y="85" width="60" height="6" rx="3" fill="#fef3c7" />
         <rect x="10" y="95" width="45" height="6" rx="3" fill="#fef3c7" />
        </g> <!-- Box 2 - 3D View --> <g transform="translate(180, 40)"><!-- Front face -->
         <path d="M0 40 L0 140 L100 140 L100 40 Z" fill="white" opacity="0.95" /> <!-- Top face -->
         <path d="M0 40 L30 20 L130 20 L100 40 Z" fill="white" opacity="0.85" /> <!-- Right face -->
         <path d="M100 40 L130 20 L130 120 L100 140 Z" fill="white" opacity="0.75" /> <!-- Design on front -->
         <ellipse cx="50" cy="80" rx="25" ry="35" fill="#fed7aa" />
         <circle cx="50" cy="70" r="12" fill="#f97316" />
         <rect x="20" y="110" width="60" height="8" rx="4" fill="#fef3c7" />
        </g> <!-- Pouch --> <g transform="translate(100, 180)">
         <ellipse cx="50" cy="15" rx="35" ry="8" fill="white" opacity="0.7" />
         <path d="M15 15 L15 75 Q15 85 25 85 L75 85 Q85 85 85 75 L85 15 Z" fill="white" opacity="0.95" />
         <rect x="30" y="30" width="40" height="40" rx="6" fill="#fed7aa" />
         <circle cx="50" cy="50" r="10" fill="#f97316" />
        </g> <!-- Decorative Elements --> <circle cx="360" cy="270" r="18" fill="white" opacity="0.3" /> <rect x="25" y="240" width="25" height="25" rx="4" fill="white" opacity="0.3" /> <!-- Title Overlay --> <rect x="0" y="230" width="400" height="90" fill="rgba(0,0,0,0.6)" /> <text x="200" y="270" font-family="Poppins, sans-serif" font-size="28" font-weight="bold" fill="white" text-anchor="middle">
         Packaging Design
        </text> <text x="200" y="295" font-family="Poppins, sans-serif" font-size="14" fill="white" text-anchor="middle" opacity="0.9">
         Product Packaging
        </text>
       </svg>
       <div class="portfolio-overlay"><a href="https://drive.google.com/drive/folders/1FjXzKSZ8S1TunF7wx2FQMCrdFnfwrlW_?usp=sharing" target="_blank" rel="noopener noreferrer" class="bg-white text-orange-600 px-6 py-3 rounded-lg font-bold hover:bg-orange-50 transition"> Lihat Detail </a>
       </div>
      </div>
     </div>
     <div class="text-center"><a href="https://drive.google.com/drive/folders/1FjXzKSZ8S1TunF7wx2FQMCrdFnfwrlW_?usp=sharing" target="_blank" rel="noopener noreferrer" class="inline-flex items-center btn-primary text-white px-8 py-4 rounded-lg font-bold text-lg shadow-xl">
       <svg class="w-6 h-6 mr-2" fill="currentColor" viewbox="0 0 20 20"><path d="M3 4a1 1 0 011-1h12a1 1 0 011 1v2a1 1 0 01-1 1H4a1 1 0 01-1-1V4zM3 10a1 1 0 011-1h6a1 1 0 011 1v6a1 1 0 01-1 1H4a1 1 0 01-1-1v-6zM14 9a1 1 0 00-1 1v6a1 1 0 001 1h2a1 1 0 001-1v-6a1 1 0 00-1-1h-2z" />
       </svg> Lihat Semua Portofolio </a>
     </div>
    </div>
   </section><!-- Contact Section -->
   <section id="contact" class="py-20 px-6 lg:px-8 fade-in section-spacing">
    <div class="max-w-7xl mx-auto">
     <div class="text-center mb-16"><span class="badge badge-purple mb-4"> 📞 Hubungi Kami </span>
      <h2 id="contact-title" class="text-4xl lg:text-5xl font-display font-bold mb-4 gradient-text">Mari Berkolaborasi</h2>
      <p id="contact-subtitle" class="text-xl text-gray-600 max-w-2xl mx-auto">Hubungi kami untuk konsultasi gratis</p>
     </div>
     <div class="grid lg:grid-cols-2 gap-12 max-w-6xl mx-auto"><!-- Contact Cards -->
      <div class="space-y-6">
       <div class="glass-card p-8 rounded-2xl shadow-lg hover-lift">
        <div class="flex items-start space-x-4">
         <div class="contact-icon-wrapper gradient-green-emerald">
          <svg class="w-7 h-7 text-white" fill="currentColor" viewbox="0 0 24 24"><path d="M17.472 14.382c-.297-.149-1.758-.867-2.03-.967-.273-.099-.471-.148-.67.15-.197.297-.767.966-.94 1.164-.173.199-.347.223-.644.075-.297-.15-1.255-.463-2.39-1.475-.883-.788-1.48-1.761-1.653-2.059-.173-.297-.018-.458.13-.606.134-.133.298-.347.446-.52.149-.174.198-.298.298-.497.099-.198.05-.371-.025-.52-.075-.149-.669-1.612-.916-2.207-.242-.579-.487-.5-.669-.51-.173-.008-.371-.01-.57-.01-.198 0-.52.074-.792.372-.272.297-1.04 1.016-1.04 2.479 0 1.462 1.065 2.875 1.213 3.074.149.198 2.096 3.2 5.077 4.487.709.306 1.262.489 1.694.625.712.227 1.36.195 1.871.118.571-.085 1.758-.719 2.006-1.413.248-.694.248-1.289.173-1.413-.074-.124-.272-.198-.57-.347m-5.421 7.403h-.004a9.87 9.87 0 01-5.031-1.378l-.361-.214-3.741.982.998-3.648-.235-.374a9.86 9.86 0 01-1.51-5.26c.001-5.45 4.436-9.884 9.888-9.884 2.64 0 5.122 1.03 6.988 2.898a9.825 9.825 0 012.893 6.994c-.003 5.45-4.437 9.884-9.885 9.884m8.413-18.297A11.815 11.815 0 0012.05 0C5.495 0 .16 5.335.157 11.892c0 2.096.547 4.142 1.588 5.945L.057 24l6.305-1.654a11.882 11.882 0 005.683 1.448h.005c6.554 0 11.89-5.335 11.893-11.893a11.821 11.821 0 00-3.48-8.413z" />
          </svg>
         </div>
         <div>
          <h3 class="font-bold text-gray-800 text-lg mb-2">WhatsApp</h3><a href="https://wa.me/6285815056990" target="_blank" rel="noopener noreferrer" class="text-green-600 hover:text-green-700 font-bold text-lg block mb-2"> 085815056990 </a>
          <p class="text-sm text-gray-600">Chat langsung untuk respons cepat</p>
         </div>
        </div>
       </div>
       <div class="glass-card p-8 rounded-2xl shadow-lg hover-lift">
        <div class="flex items-start space-x-4">
         <div class="contact-icon-wrapper gradient-blue-cyan-solid">
          <svg class="w-7 h-7 text-white" fill="currentColor" viewbox="0 0 20 20"><path d="M2.003 5.884L10 9.882l7.997-3.998A2 2 0 0016 4H4a2 2 0 00-1.997 1.884z" /> <path d="M18 8.118l-8 4-8-4V14a2 2 0 002 2h12a2 2 0 002-2V8.118z" />
          </svg>
         </div>
         <div>
          <h3 class="font-bold text-gray-800 text-lg mb-2">Email</h3><a href="mailto:designbendel@gmail.com" class="text-blue-600 hover:text-blue-700 font-bold text-lg break-all block mb-2"> designbendel@gmail.com </a>
          <p class="text-sm text-gray-600">Kirim email untuk pertanyaan detail</p>
         </div>
        </div>
       </div>
       <div class="glass-card p-8 rounded-2xl shadow-lg hover-lift">
        <div class="flex items-start space-x-4">
         <div class="contact-icon-wrapper gradient-red-rose">
          <svg class="w-7 h-7 text-white" fill="currentColor" viewbox="0 0 20 20"><path fill-rule="evenodd" d="M5.05 4.05a7 7 0 119.9 9.9L10 18.9l-4.95-4.95a7 7 0 010-9.9zM10 11a2 2 0 100-4 2 2 0 000 4z" clip-rule="evenodd" />
          </svg>
         </div>
         <div>
          <h3 class="font-bold text-gray-800 text-lg mb-2">Alamat Studio</h3>
          <p class="text-gray-600 leading-relaxed">Jl. KH Ahmad Dahlan RT 02 RW 02<br>
            Rumah No. 40, Desa Mojopetung<br>
            Kec. Dukun, Kab. Gresik</p>
         </div>
        </div>
       </div>
      </div><!-- CTA Box -->
      <div class="relative">
       <div class="cta-box-bg"></div>
       <div class="cta-box-content glass-card">
        <div class="text-center mb-6">
         <div class="inline-block p-4 gradient-pink-purple rounded-2xl mb-4">
          <svg class="w-12 h-12 text-purple-600" fill="none" stroke="currentColor" viewbox="0 0 24 24"><path stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M13 10V3L4 14h7v7l9-11h-7z" />
          </svg>
         </div>
         <h3 class="text-3xl font-display font-bold mb-3 gradient-text">Mulai Project Anda</h3>
         <p class="text-gray-600 leading-relaxed mb-8">Konsultasikan kebutuhan desain grafis bisnis UMKM Anda dengan tim profesional kami. Gratis dan tanpa komitmen!</p>
        </div><a href="https://wa.me/6285815056990" target="_blank" rel="noopener noreferrer" class="block btn-primary text-white px-8 py-4 rounded-xl font-bold text-center shadow-xl mb-6 text-lg"> 💬 Konsultasi Gratis Sekarang </a>
        <div class="feature-grid">
         <div class="feature-item">
          <div class="feature-icon">
           ⚡
          </div>
          <p class="feature-label">Respon Cepat</p>
         </div>
         <div class="feature-item">
          <div class="feature-icon">
           🎨
          </div>
          <p class="feature-label">Desain Berkualitas</p>
         </div>
         <div class="feature-item">
          <div class="feature-icon">
           💯
          </div>
          <p class="feature-label">Harga Terjangkau</p>
         </div>
        </div>
       </div>
      </div>
     </div>
    </div>
   </section><!-- Footer -->
   <footer class="text-white py-16 px-6 lg:px-8">
    <div class="max-w-7xl mx-auto">
     <div class="grid md:grid-cols-3 gap-12 mb-12">
      <div>
       <div class="flex items-center space-x-3 mb-4">
        <div class="w-12 h-12 bg-gradient-to-br from-purple-600 to-indigo-600 rounded-xl flex items-center justify-center"><span class="text-white font-bold text-2xl">A</span>
        </div>
        <div>
         <h3 class="text-xl font-bold">Awalan Design.id</h3>
         <p class="text-sm text-purple-300">Creative Studio</p>
        </div>
       </div>
       <p class="text-gray-300 leading-relaxed">Jasa desain grafis profesional untuk UMKM Indonesia dengan harga terjangkau dan kualitas premium.</p>
      </div>
      <div>
       <h4 class="font-bold text-lg mb-4">Layanan</h4>
       <ul class="space-y-2 text-gray-300">
        <li>Logo &amp; Brand Identity</li>
        <li>Social Media Design</li>
        <li>Packaging Design</li>
        <li>Flyer &amp; Brochure</li>
        <li>Banner &amp; Signage</li>
        <li>Sticker &amp; Label</li>
       </ul>
      </div>
      <div>
       <h4 class="font-bold text-lg mb-4">Hubungi Kami</h4>
       <ul class="space-y-3 text-gray-300">
        <li class="flex items-center space-x-2">
         <svg class="w-5 h-5 text-green-400" fill="currentColor" viewbox="0 0 20 20"><path d="M2 3a1 1 0 011-1h2.153a1 1 0 01.986.836l.74 4.435a1 1 0 01-.54 1.06l-1.548.773a11.037 11.037 0 006.105 6.105l.774-1.548a1 1 0 011.059-.54l4.435.74a1 1 0 01.836.986V17a1 1 0 01-1 1h-2C7.82 18 2 12.18 2 5V3z" />
         </svg><a href="https://wa.me/6285815056990" target="_blank" rel="noopener noreferrer" class="hover:text-white transition">085815056990</a></li>
        <li class="flex items-center space-x-2">
         <svg class="w-5 h-5 text-blue-400" fill="currentColor" viewbox="0 0 20 20"><path d="M2.003 5.884L10 9.882l7.997-3.998A2 2 0 0016 4H4a2 2 0 00-1.997 1.884z" /> <path d="M18 8.118l-8 4-8-4V14a2 2 0 002 2h12a2 2 0 002-2V8.118z" />
         </svg><a href="mailto:designbendel@gmail.com" class="hover:text-white transition break-all">designbendel@gmail.com</a></li>
        <li class="flex items-start space-x-2">
         <svg class="w-5 h-5 text-red-400 mt-1" fill="currentColor" viewbox="0 0 20 20"><path fill-rule="evenodd" d="M5.05 4.05a7 7 0 119.9 9.9L10 18.9l-4.95-4.95a7 7 0 010-9.9zM10 11a2 2 0 100-4 2 2 0 000 4z" clip-rule="evenodd" />
         </svg><span>Desa Mojopetung, Kec. Dukun, Kab. Gresik</span></li>
       </ul>
      </div>
     </div>
     <div class="section-divider"></div>
     <div class="text-center">
      <p id="footer-text" class="text-gray-400">© 2024 Awalan Design.id. All rights reserved.</p>
     </div>
    </div>
   </footer>
  </div>
  <script>
    /* ==========================================
       CONFIGURATION & SETUP
       ========================================== */
    const defaultConfig = {
      company_name: "Awalan Design.id",
      tagline: "Studio Desain Grafis UMKM",
      hero_title: "Wujudkan Brand Impian Anda",
      hero_subtitle: "Desain Grafis Profesional untuk UMKM Indonesia",
      cta_button: "Konsultasi Gratis",
      services_title: "Layanan Kami",
      services_subtitle: "Solusi desain lengkap untuk bisnis UMKM",
      contact_title: "Mari Berkolaborasi",
      contact_subtitle: "Hubungi kami untuk konsultasi gratis",
      footer_text: "© 2024 Awalan Design.id. All rights reserved.",
      background_color: "#f9fafb",
      primary_color: "#667eea",
      secondary_color: "#764ba2",
      text_color: "#1f2937",
      accent_color: "#ec4899",
      font_family: "Poppins",
      font_size: 16
    };

    /* ==========================================
       ELEMENT SDK INTEGRATION
       ========================================== */
    async function onConfigChange(config) {
      const customFont = config.font_family || defaultConfig.font_family;
      const baseSize = config.font_size || defaultConfig.font_size;
      const baseFontStack = 'sans-serif';

      // Apply font family
      document.body.style.fontFamily = `${customFont}, ${baseFontStack}`;
      
      // Apply font sizes proportionally
      const heroTitle = document.getElementById('hero-title');
      if (heroTitle) heroTitle.style.fontSize = `${baseSize * 3}px`;
      
      const heroSubtitle = document.getElementById('hero-subtitle');
      if (heroSubtitle) heroSubtitle.style.fontSize = `${baseSize * 1.25}px`;
      
      document.querySelectorAll('h2').forEach(el => el.style.fontSize = `${baseSize * 2.5}px`);
      document.querySelectorAll('h3').forEach(el => el.style.fontSize = `${baseSize * 1.5}px`);
      document.querySelectorAll('p').forEach(el => el.style.fontSize = `${baseSize}px`);

      // Update text content from config
      const navBrand = document.getElementById('nav-brand');
      if (navBrand) navBrand.textContent = config.company_name || defaultConfig.company_name;
      
      const navTagline = document.getElementById('nav-tagline');
      if (navTagline) navTagline.textContent = config.tagline || defaultConfig.tagline;
      
      if (heroTitle) heroTitle.textContent = config.hero_title || defaultConfig.hero_title;
      if (heroSubtitle) heroSubtitle.textContent = config.hero_subtitle || defaultConfig.hero_subtitle;
      
      const ctaButton = document.getElementById('cta-button');
      if (ctaButton) ctaButton.textContent = config.cta_button || defaultConfig.cta_button;
      
      const servicesTitle = document.getElementById('services-title');
      if (servicesTitle) servicesTitle.textContent = config.services_title || defaultConfig.services_title;
      
      const servicesSubtitle = document.getElementById('services-subtitle');
      if (servicesSubtitle) servicesSubtitle.textContent = config.services_subtitle || defaultConfig.services_subtitle;
      
      const contactTitle = document.getElementById('contact-title');
      if (contactTitle) contactTitle.textContent = config.contact_title || defaultConfig.contact_title;
      
      const contactSubtitle = document.getElementById('contact-subtitle');
      if (contactSubtitle) contactSubtitle.textContent = config.contact_subtitle || defaultConfig.contact_subtitle;
      
      const footerText = document.getElementById('footer-text');
      if (footerText) footerText.textContent = config.footer_text || defaultConfig.footer_text;
    }

    function mapToCapabilities(config) {
      return {
        recolorables: [
          {
            get: () => config.background_color || defaultConfig.background_color,
            set: (value) => {
              config.background_color = value;
              if (window.elementSdk) window.elementSdk.setConfig({ background_color: value });
            }
          },
          {
            get: () => config.primary_color || defaultConfig.primary_color,
            set: (value) => {
              config.primary_color = value;
              if (window.elementSdk) window.elementSdk.setConfig({ primary_color: value });
            }
          },
          {
            get: () => config.secondary_color || defaultConfig.secondary_color,
            set: (value) => {
              config.secondary_color = value;
              if (window.elementSdk) window.elementSdk.setConfig({ secondary_color: value });
            }
          },
          {
            get: () => config.text_color || defaultConfig.text_color,
            set: (value) => {
              config.text_color = value;
              if (window.elementSdk) window.elementSdk.setConfig({ text_color: value });
            }
          },
          {
            get: () => config.accent_color || defaultConfig.accent_color,
            set: (value) => {
              config.accent_color = value;
              if (window.elementSdk) window.elementSdk.setConfig({ accent_color: value });
            }
          }
        ],
        borderables: [],
        fontEditable: {
          get: () => config.font_family || defaultConfig.font_family,
          set: (value) => {
            config.font_family = value;
            if (window.elementSdk) window.elementSdk.setConfig({ font_family: value });
          }
        },
        fontSizeable: {
          get: () => config.font_size || defaultConfig.font_size,
          set: (value) => {
            config.font_size = value;
            if (window.elementSdk) window.elementSdk.setConfig({ font_size: value });
          }
        }
      };
    }

    function mapToEditPanelValues(config) {
      return new Map([
        ["company_name", config.company_name || defaultConfig.company_name],
        ["tagline", config.tagline || defaultConfig.tagline],
        ["hero_title", config.hero_title || defaultConfig.hero_title],
        ["hero_subtitle", config.hero_subtitle || defaultConfig.hero_subtitle],
        ["cta_button", config.cta_button || defaultConfig.cta_button],
        ["services_title", config.services_title || defaultConfig.services_title],
        ["services_subtitle", config.services_subtitle || defaultConfig.services_subtitle],
        ["contact_title", config.contact_title || defaultConfig.contact_title],
        ["contact_subtitle", config.contact_subtitle || defaultConfig.contact_subtitle],
        ["footer_text", config.footer_text || defaultConfig.footer_text]
      ]);
    }

    // Initialize Element SDK
    if (window.elementSdk) {
      window.elementSdk.init({
        defaultConfig,
        onConfigChange,
        mapToCapabilities,
        mapToEditPanelValues
      });
    }

    /* ==========================================
       MOBILE MENU TOGGLE
       ========================================== */
    function toggleMobileMenu() {
      const menu = document.getElementById('mobile-menu');
      if (menu) menu.classList.toggle('hidden');
    }

    /* ==========================================
       SMOOTH SCROLL NAVIGATION
       ========================================== */
    function initSmoothScroll() {
      document.querySelectorAll('a[href^="#"]').forEach(anchor => {
        anchor.addEventListener('click', function (e) {
          e.preventDefault();
          const target = document.querySelector(this.getAttribute('href'));
          if (target) {
            target.scrollIntoView({ behavior: 'smooth', block: 'start' });
            
            // Close mobile menu after navigation
            const menu = document.getElementById('mobile-menu');
            if (menu && !menu.classList.contains('hidden')) {
              menu.classList.add('hidden');
            }
          }
        });
      });
    }

    /* ==========================================
       STICKY NAVIGATION BAR
       ========================================== */
    function initStickyNav() {
      const nav = document.querySelector('nav');
      let lastScroll = 0;

      window.addEventListener('scroll', () => {
        const currentScroll = window.pageYOffset;
        
        if (currentScroll > 100) {
          nav.classList.add('shadow-xl');
        } else {
          nav.classList.remove('shadow-xl');
        }
        
        lastScroll = currentScroll;
      });
    }

    /* ==========================================
       INTERSECTION OBSERVER FOR ANIMATIONS
       ========================================== */
    function initScrollAnimations() {
      const observerOptions = {
        threshold: 0.1,
        rootMargin: '0px 0px -50px 0px'
      };

      const observer = new IntersectionObserver((entries) => {
        entries.forEach(entry => {
          if (entry.isIntersecting) {
            entry.target.style.opacity = '1';
            entry.target.style.transform = 'translateY(0)';
          }
        });
      }, observerOptions);

      // Observe all service cards and portfolio items
      document.querySelectorAll('.service-card, .portfolio-item').forEach(el => {
        el.style.opacity = '0';
        el.style.transform = 'translateY(30px)';
        el.style.transition = 'opacity 0.6s ease-out, transform 0.6s ease-out';
        observer.observe(el);
      });
    }

    /* ==========================================
       STATS COUNTER ANIMATION
       ========================================== */
    function animateStats() {
      const stats = [
        { element: document.querySelector('.stat-number:nth-of-type(1)'), target: 100, suffix: '+' },
        { element: document.querySelector('.stat-number:nth-of-type(2)'), target: 500, suffix: '+' },
        { element: document.querySelector('.stat-number:nth-of-type(3)'), target: 5, suffix: '★' }
      ];

      const observer = new IntersectionObserver((entries) => {
        entries.forEach(entry => {
          if (entry.isIntersecting && !entry.target.dataset.animated) {
            const statData = stats.find(s => s.element === entry.target);
            if (statData) {
              animateCounter(statData.element, 0, statData.target, statData.suffix, 2000);
              entry.target.dataset.animated = 'true';
            }
          }
        });
      }, { threshold: 0.5 });

      stats.forEach(stat => {
        if (stat.element) observer.observe(stat.element);
      });
    }

    function animateCounter(element, start, end, suffix, duration) {
      const range = end - start;
      const increment = range / (duration / 16);
      let current = start;

      const timer = setInterval(() => {
        current += increment;
        if (current >= end) {
          current = end;
          clearInterval(timer);
        }
        element.textContent = Math.floor(current) + suffix;
      }, 16);
    }

    /* ==========================================
       SERVICE CARD HOVER EFFECTS
       ========================================== */
    function initServiceCardEffects() {
      const serviceCards = document.querySelectorAll('.service-card');
      
      serviceCards.forEach(card => {
        card.addEventListener('mouseenter', function() {
          this.style.transform = 'translateY(-12px) scale(1.02)';
        });
        
        card.addEventListener('mouseleave', function() {
          this.style.transform = 'translateY(0) scale(1)';
        });
      });
    }

    /* ==========================================
       PORTFOLIO FILTER (IF NEEDED IN FUTURE)
       ========================================== */
    function initPortfolioFilter() {
      const portfolioItems = document.querySelectorAll('.portfolio-item');
      
      portfolioItems.forEach((item, index) => {
        item.style.animationDelay = `${index * 0.1}s`;
      });
    }

    /* ==========================================
       SCROLL TO TOP BUTTON
       ========================================== */
    function initScrollToTop() {
      const scrollBtn = document.createElement('button');
      scrollBtn.innerHTML = '↑';
      scrollBtn.className = 'fixed bottom-24 right-8 w-12 h-12 bg-purple-600 text-white rounded-full shadow-xl opacity-0 transition-opacity duration-300 hover:bg-purple-700 z-40';
      scrollBtn.style.pointerEvents = 'none';
      document.body.appendChild(scrollBtn);

      window.addEventListener('scroll', () => {
        if (window.pageYOffset > 500) {
          scrollBtn.style.opacity = '1';
          scrollBtn.style.pointerEvents = 'auto';
        } else {
          scrollBtn.style.opacity = '0';
          scrollBtn.style.pointerEvents = 'none';
        }
      });

      scrollBtn.addEventListener('click', () => {
        window.scrollTo({ top: 0, behavior: 'smooth' });
      });
    }

    /* ==========================================
       PARALLAX EFFECT FOR HERO
       ========================================== */
    function initParallaxEffect() {
      const hero = document.querySelector('.hero-bg');
      
      window.addEventListener('scroll', () => {
        const scrolled = window.pageYOffset;
        if (hero && scrolled < window.innerHeight) {
          hero.style.transform = `translateY(${scrolled * 0.5}px)`;
        }
      });
    }

    /* ==========================================
       TYPING EFFECT FOR HERO TITLE
       ========================================== */
    function initTypingEffect() {
      const heroTitle = document.getElementById('hero-title');
      if (!heroTitle) return;

      const originalText = heroTitle.textContent;
      heroTitle.textContent = '';
      heroTitle.style.opacity = '1';
      
      let charIndex = 0;
      const typingSpeed = 80;

      function typeChar() {
        if (charIndex < originalText.length) {
          heroTitle.textContent += originalText.charAt(charIndex);
          charIndex++;
          setTimeout(typeChar, typingSpeed);
        }
      }

      // Start typing after a short delay
      setTimeout(typeChar, 500);
    }

    /* ==========================================
       LAZY LOAD IMAGES (IF ANY)
       ========================================== */
    function initLazyLoad() {
      const images = document.querySelectorAll('img[data-src]');
      
      const imageObserver = new IntersectionObserver((entries) => {
        entries.forEach(entry => {
          if (entry.isIntersecting) {
            const img = entry.target;
            img.src = img.dataset.src;
            img.removeAttribute('data-src');
            imageObserver.unobserve(img);
          }
        });
      });

      images.forEach(img => imageObserver.observe(img));
    }

    /* ==========================================
       CURSOR TRAIL EFFECT (OPTIONAL FANCY FEATURE)
       ========================================== */
    function initCursorTrail() {
      let dots = [];
      const maxDots = 15;

      document.addEventListener('mousemove', (e) => {
        const dot = document.createElement('div');
        dot.className = 'cursor-dot';
        dot.style.left = e.pageX + 'px';
        dot.style.top = e.pageY + 'px';
        document.body.appendChild(dot);
        dots.push(dot);

        if (dots.length > maxDots) {
          const oldDot = dots.shift();
          oldDot.remove();
        }

        setTimeout(() => {
          dot.style.opacity = '0';
          setTimeout(() => dot.remove(), 500);
        }, 500);
      });

      // Add cursor dot styles
      const style = document.createElement('style');
      style.textContent = `
        .cursor-dot {
          position: absolute;
          width: 8px;
          height: 8px;
          background: linear-gradient(135deg, #667eea, #764ba2);
          border-radius: 50%;
          pointer-events: none;
          z-index: 9999;
          transition: opacity 0.5s ease;
          opacity: 0.6;
        }
      `;
      document.head.appendChild(style);
    }

    /* ==========================================
       INITIALIZE ALL INTERACTIONS
       ========================================== */
    document.addEventListener('DOMContentLoaded', () => {
      // Core functionality
      initSmoothScroll();
      initStickyNav();
      
      // Animations
      initScrollAnimations();
      animateStats();
      
      // Interactive effects
      initServiceCardEffects();
      initPortfolioFilter();
      initScrollToTop();
      
      // Optional fancy effects (comment out if too much)
      // initParallaxEffect();
      // initTypingEffect();
      // initCursorTrail();
      
      console.log('🎨 Awalan Design.id - Website Loaded Successfully!');
    });
  </script>
 <script>(function(){function c(){var b=a.contentDocument||a.contentWindow.document;if(b){var d=b.createElement('script');d.innerHTML="window.__CF$cv$params={r:'9b99076c26838beb',t:'MTc2NzY3OTU4Mi4wMDAwMDA='};var a=document.createElement('script');a.nonce='';a.src='/cdn-cgi/challenge-platform/scripts/jsd/main.js';document.getElementsByTagName('head')[0].appendChild(a);";b.getElementsByTagName('head')[0].appendChild(d)}}if(document.body){var a=document.createElement('iframe');a.height=1;a.width=1;a.style.position='absolute';a.style.top=0;a.style.left=0;a.style.border='none';a.style.visibility='hidden';document.body.appendChild(a);if('loading'!==document.readyState)c();else if(window.addEventListener)document.addEventListener('DOMContentLoaded',c);else{var e=document.onreadystatechange||function(){};document.onreadystatechange=function(b){e(b);'loading'!==document.readyState&&(document.onreadystatechange=e,c())}}}})();</script></body>
</html>