const requestWindowOpenBtn = document.querySelector(".request__btn--open")
const requestWindowSendBtn = document.querySelector(".request__btn--send")
const requestWindowCloseBtn = document.querySelector(".request__btn-close")
const requestWindow = document.querySelector(".request__window")
// const windowCloseBtn = document.querySelector(".request__btn--open")

requestWindowOpenBtn.addEventListener('click', requestWindowToggle);
requestWindowSendBtn.addEventListener('click', requestWindowToggle);
requestWindowCloseBtn.addEventListener('click', requestWindowToggle);

function requestWindowToggle(){
    requestWindow.classList.toggle("request__window--active")
}
