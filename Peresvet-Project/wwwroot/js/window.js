const requestWindowOpenBtn = document.querySelector(".request__btn--open");
const requestWindowSendBtn = document.querySelector(".request__btn--send");
const requestWindowCloseBtn = document.querySelector(".request__btn-close");
const requestWindow = document.querySelector(".request__window");

function requestWindowToggle() {
    requestWindow.classList.toggle("request__window--active");
    body.classList.toggle("noscroll")
}

if (requestWindowOpenBtn) {
    requestWindowOpenBtn.addEventListener('click', requestWindowToggle);
}

if (requestWindowSendBtn) {
    requestWindowSendBtn.addEventListener('click', requestWindowToggle);
}

if (requestWindowCloseBtn) {
    requestWindowCloseBtn.addEventListener('click', requestWindowToggle);
}
