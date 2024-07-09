document.addEventListener('DOMContentLoaded', function () {
    const topnav = document.querySelector('.topnav');
    window.addEventListener('scroll', function () {
        if (window.scrollY > 50) topnav.classList.add('scrollednav', 'py-0');
        else topnav.classList.remove('scrollednav', 'py-0');
    });
});

function toggleMenu(e) {
    e.target.classList.toggle('collapsed');
    document.getElementById('top-navbar-wrapper').classList.toggle('show');
}
