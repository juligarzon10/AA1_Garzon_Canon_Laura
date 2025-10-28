@charset "UTF-8";
/* ===========================
   Peli.Fix – SCSS principal
   Requisitos: variables, anidación, interpolación
   =========================== */
/* ---------- Variables globales (>=5) ---------- */
/* Map para utilidades (lo usamos en interpolación #1) */
/* Breakpoints útiles (opcional) */
/* ---------- Reset corto ---------- */
*, *::before, *::after {
  box-sizing: border-box;
}

/* ---------- Body + tema claro ---------- */
html, body {
  margin: 0;
  font-family: "Roboto", system-ui, -apple-system, Segoe UI, Arial, sans-serif;
  background: #151515;
  color: #ffffff;
  overflow-x: hidden;
  /* Tema claro activado con body.light */
}
html.light, body.light {
  background: #ffffff;
  color: #111111;
}

/* Contenedor principal correteado por el sidebar */
#main {
  padding-left: 60px;
}

/* ---------- Navbar ---------- */
.navbar {
  background: #000 !important;
  color: #ffffff !important;
}
.navbar .navbar-brand {
  font-weight: 700;
}
.navbar .text-white-50 {
  color: #bdbdbd !important;
}
.navbar {
  /* tema claro */
}
body.light .navbar {
  background: #f8f9fa !important;
  color: #000 !important;
}

/* ---------- Sidebar con íconos ---------- */
.sidebar {
  position: fixed;
  inset: 0 auto 0 0;
  width: 50px;
  background: #151515;
  padding-top: 68px;
  display: flex;
  flex-direction: column;
  align-items: center;
  gap: 50px;
}
.sidebar .btn-icon {
  background: transparent;
  border: 0;
  padding: 0;
  cursor: pointer;
}
.sidebar .left-menu-icon {
  color: #ffffff;
  font-size: 20px;
}
.sidebar {
  /* tema claro */
}
body.light .sidebar {
  background: #ffffff;
}
body.light .sidebar .left-menu-icon {
  color: #000 !important;
}

/* ---------- Buscador emergente ---------- */
.search-box {
  position: relative;
  width: 50px;
  display: flex;
  justify-content: center;
}
.search-box .left-menu-icon {
  pointer-events: none;
}
.search-box .search-input {
  position: absolute;
  left: 50px;
  top: -2px;
  width: 0;
  opacity: 0;
  height: 32px;
  background: #1e1e1e;
  color: #ffffff;
  border: none;
  outline: none;
  border-radius: 6px;
  padding: 0 10px;
  font-size: 14px;
  transition: width 0.35s ease, opacity 0.35s ease;
  z-index: 2000;
}
.search-box:hover .search-input {
  width: 180px;
  opacity: 1;
}
.search-box {
  /* tema claro */
}
body.light .search-box .search-input {
  background: #f1f1f1;
  color: #111;
}

/* ---------- Hero ---------- */
.hero {
  min-height: 60vh;
  display: grid;
  align-items: center;
  padding: 80px 16px 40px;
  background: linear-gradient(to bottom, rgba(0, 0, 0, 0.25), rgb(21, 21, 21)), url("Imagenes/blackphone.jpg") center/cover no-repeat !important;
}
.hero .hero__content {
  max-width: 900px;
}
.hero .hero__content h1 {
  font-weight: 800;
  text-shadow: 0 2px 8px rgba(0, 0, 0, 0.45);
}
.hero .hero__content .lead {
  color: #bdbdbd;
}
.hero {
  /* tema claro, mantiene el degradé para legibilidad */
}
body.light .hero {
  background: linear-gradient(to bottom, rgba(0, 0, 0, 0.35), rgba(21, 21, 21, 0.5)), url("Imagenes/blackphone.jpg") center/cover no-repeat !important;
}
body.light .hero .lead {
  color: #e8e8e8;
}

/* ---------- Títulos de sección ---------- */
.section-title {
  font-weight: 800;
  margin-bottom: 1.25rem;
}

/* ---------- Movie card (anidación) ---------- */
.movie-card {
  background: #111111 !important;
  color: #ffffff;
  border: 0;
  border-radius: 16px;
  overflow: hidden;
  transition: transform 0.25s ease, box-shadow 0.25s ease;
}
.movie-card img {
  display: block;
  margin: 0 auto;
  width: 100%;
  height: 220px;
  object-fit: cover;
  transition: transform 0.25s ease, opacity 0.25s ease;
}
.movie-card:hover {
  transform: translateY(-2px);
  box-shadow: 0 10px 30px rgba(0, 0, 0, 0.35);
}
.movie-card:hover img {
  transform: scale(1.05);
  opacity: 0.95;
}
.movie-card {
  /* tema claro */
}
body.light .movie-card {
  background: #f5f5f5 !important;
  color: #000 !important;
}

/* ---------- Lista de comentarios ---------- */
.comments-list {
  list-style: none;
  margin: 0;
  padding: 0;
}
.comments-list li {
  background: #1a1a1a;
  border-radius: 10px;
  padding: 0.75rem 0.9rem;
  margin-bottom: 0.5rem;
}
.comments-list li .meta {
  font-size: 0.8rem;
  opacity: 0.7;
  margin-bottom: 0.25rem;
}
body.light .comments-list li {
  background: #efefef;
}

/* ---------- Clamp util ---------- */
.clamp-5 {
  display: -webkit-box;
  -webkit-line-clamp: 5;
  line-clamp: 5;
  -webkit-box-orient: vertical;
  overflow: hidden;
}

/* ---------- Toggle de tema ---------- */
.theme-toggle {
  width: 56px;
  height: 28px;
  background: #fff;
  border-radius: 999px;
  display: flex;
  align-items: center;
  justify-content: space-between;
  padding: 0 8px;
  position: relative;
}
.theme-toggle i {
  font-size: 14px;
  color: #f1c40f;
  pointer-events: none;
}
.theme-toggle .toggle-ball {
  position: absolute;
  top: 4px;
  left: 4px;
  width: 20px;
  height: 20px;
  border-radius: 50%;
  background: #151515;
  transition: transform 0.3s ease;
}
.theme-toggle {
  /* cuando body.light, mueve la bolita */
}
body.light .theme-toggle .toggle-ball {
  transform: translateX(28px);
  background: #000;
}

/* ---------- Botones ----------
   Interpolación #1: generamos variantes .btn-brand y .btn-success
   (forzamos success a rojo marca para que tu HTML actual también quede rojo) */
.btn-brand, .btn-success {
  background: #e50914 !important;
  border-color: #e50914 !important;
  color: #fff !important;
}
.btn-brand:hover, .btn-success:hover, .btn-brand:focus, .btn-success:focus {
  background: rgb(194.65, 7.65, 17) !important;
  border-color: rgb(194.65, 7.65, 17) !important;
  color: #fff !important;
}

.btn-success {
  background: #e50914 !important;
  border-color: #e50914 !important;
  color: #fff !important;
}
.btn-success:hover, .btn-success:focus {
  background: rgb(194.65, 7.65, 17) !important;
  border-color: rgb(194.65, 7.65, 17) !important;
  color: #fff !important;
}

/* Si sigues usando .btn-success de Bootstrap, aquí lo dejamos rojo marca */
/* ---------- Secciones con interpolación ----------
   Interpolación #2: clases utilitarias para secciones por nombre */
.section--nuevos {
  scroll-margin-top: 90px;
  border-top: 2px solid rgba(255, 255, 255, 0.07);
  padding-top: 1rem;
}

.section--popular {
  scroll-margin-top: 90px;
  border-top: 2px solid rgba(255, 255, 255, 0.07);
  padding-top: 1rem;
}

.section--critica {
  scroll-margin-top: 90px;
  border-top: 2px solid rgba(255, 255, 255, 0.07);
  padding-top: 1rem;
}

/* ---------- Responsivo básico ---------- */
@media (max-width: 576px) {
  #main {
    padding-left: 60px;
  }
  .hero {
    padding-top: 96px;
  }
}

/*# sourceMappingURL=style.cs.map */
