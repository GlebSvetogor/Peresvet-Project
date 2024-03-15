const windowOpenBtn = document.querySelector(".request__btn--open")
const windowSendBtn = document.querySelector(".request__btn--send")
const window = document.querySelector(".request__window")
// const windowCloseBtn = document.querySelector(".request__btn--open")

windowOpenBtn.addEventListener('click', requestWindowToggle);

windowSendBtn.addEventListener('click', requestWindowToggle);

function requestWindowToggle(){
    window.classList.toggle("request__window--active")
}
