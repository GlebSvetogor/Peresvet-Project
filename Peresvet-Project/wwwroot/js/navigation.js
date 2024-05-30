const liElements = document.querySelectorAll(".nav__list-item");
const activeLiClassName = "nav__list-item--active";
const indexTextValue = "Главная";

liElements.forEach((li) =>
    li.addEventListener('click', () => {
        if (!li.classList.contains(activeLiClassName)) {
            console.log(li);
            const activeLiElement = Array.from(liElements).find(el => el.classList.contains(activeLiClassName));
            if (activeElement != null) {
                activeLi.classList.remove(activeLiClassName);
                li.classList.add(activeLiClassName);
            }else {
                const liWithMainLink = Array.from(liElements).find(li => {
                    const link = li.querySelector('a.nav__list-link');
                    return link && link.textContent.trim() === searchText;
                });
                liWithMainLink.classList.add(activeLiClassName);
            }
        }

    })
);