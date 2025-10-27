const searchInput = document.querySelector('.search-input');
if (searchInput){
  searchInput.addEventListener('focus', () => {
    searchInput.style.width = "180px";
    searchInput.style.opacity = "1";
  });
  searchInput.addEventListener('blur', () => {
    if(searchInput.value.trim() === ""){
      searchInput.style.width = "0px";
      searchInput.style.opacity = "0";
    }
  });
}

function storageKey(id){ return `comments:${id}`; }
function loadComments(id){ try { return JSON.parse(localStorage.getItem(storageKey(id))) || []; } catch { return []; } }
function saveComments(id, list){ localStorage.setItem(storageKey(id), JSON.stringify(list)); }

function renderComments(container){
  const movieId = container.dataset.movieId;
  const ul = container.querySelector('.comments-list');
  const comments = loadComments(movieId);
  ul.innerHTML = '';
  comments.forEach(c => {
    const li = document.createElement('li');
    li.innerHTML = `<div class="meta">${c.author} • ${new Date(c.date).toLocaleString()}</div>
                    <div class="text">${c.text.replace(/\n/g,'<br>')}</div>`;
    ul.appendChild(li);
  });
}

document.querySelectorAll('.comments').forEach(container => {
  const form = container.querySelector('.comments-form');
  renderComments(container);
  form.addEventListener('submit', (e) => {
    e.preventDefault();
    const author = form.author.value.trim();
    const text   = form.text.value.trim();
    if(!author || !text) return;
    const movieId = container.dataset.movieId;
    const list = loadComments(movieId);
    list.unshift({ author, text, date: Date.now() });
    saveComments(movieId, list);
    form.reset();
    renderComments(container);
  });
});

// ==== Cambio de tema claro/oscuro ====
const toggle = document.querySelector('.theme-toggle');
if (toggle) {
  toggle.addEventListener('click', () => {
    document.body.classList.toggle('light');
    localStorage.setItem('theme', document.body.classList.contains('light') ? 'light' : 'dark');
  });

  // Mantener tema guardado
  const savedTheme = localStorage.getItem('theme');
  if (savedTheme === 'light') document.body.classList.add('light');
}

