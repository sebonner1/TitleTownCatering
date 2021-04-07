const loginForm = document.getElementById("login-form");
const loginButton = document.getElementById("login-form-submit");
const loginErrorMsg = document.getElementById("login-error-msg");

// the below syntax from research
loginButton.addEventListener("click", (e) => {
    e.preventDefault();
    const username = loginForm.username.value;
    const password = loginForm.password.value;

    // The manager login is below
    if (username === "TTCManager" && password === "TitleTown") {
        alert("You have successfully logged in.");
        location.reload();
        let html = "<a href="../ManagerDasboard.html"></a>";
    } else {
        loginErrorMsg.style.opacity = 1;
    }
})