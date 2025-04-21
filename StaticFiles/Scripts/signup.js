const form = document.getElementById("signup");
const email = document.getElementById("email");
const password = document.getElementById("password");
const firstName = document.getElementById("first-name");
const lastName = document.getElementById("last-name");
const phoneNumber = document.getElementById("phone-number");
const address = document.getElementById("address");
const passwordRepeat = document.getElementById("password-repeat");
const message = document.getElementById("message");

form.addEventListener("submit", formSender);

async function formSender(event) {
    event.preventDefault();

    if (password.value !== passwordRepeat.value) {
        message.innerText = "Пароль не совпадает"
        return
    }

    const formData = new FormData();
    formData.append("email", email.value)
    formData.append("password", password.value)
    formData.append("firstname", firstName.value)
    formData.append("lastname", lastName.value)
    formData.append("phonenumber", phoneNumber.value)
    formData.append("address", address.value)

    const response = await fetch("/signup", { method: "POST", body: formData });

    if (response.status !== 200) {
        message.innerText = "Аккаунт с такой почтой уже существует"
        return
    }

    window.location.href = "/"
}