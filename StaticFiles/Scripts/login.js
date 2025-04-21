const form = document.getElementById("login");
const email = document.getElementById("email");
const password = document.getElementById("password");
const message = document.getElementById("message")

form.addEventListener("submit", formSender);

async function formSender(event) {
    event.preventDefault();

    const formData = new FormData();
    formData.append("email", email.value)
    formData.append("password", password.value)

    const response = await fetch("/login", { method: "POST", body: formData });

    if (response.status !== 200) {
        message.innerText = "Вы указали почту или пароль неправильно"
        return
    }

    window.location.href = "/"
}