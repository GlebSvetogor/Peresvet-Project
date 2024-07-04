document.addEventListener('DOMContentLoaded', () => {
    const liElements = document.querySelectorAll(".nav__list-item");
    const activeLiClassName = "nav__list-item--active"

    liElements.forEach((li) => {
        li.addEventListener('click', () => {
            liElements.forEach(li => li.classList.remove(activeLiClassName));
            li.classList.add(activeLiClassName);
        });
    })
    const currentPath = window.location.pathname;
    liElements.forEach((li) => {
        const link = li.querySelector('a.nav__list-link');
        if (link && link.getAttribute('href') == currentPath) {
            li.classList.add(activeLiClassName);
        }
    })
})
