const loginForm = document.getElementById("login-form");
const loginButton = document.getElementById("login-form-submit");
const loginErrorMsg = document.getElementById("login-error-msg");

// the below syntax from research
loginButton.addEventListener("click", (e) => {
    e.preventDefault();
    const username = loginForm.username.value;
    const password = loginForm.password.value;

    // The manager login is below, working on taking it to the next page, the dashboard
    if (username === "TTCManager" && password === "TitleTown") {
        alert("You have successfully logged in.");
        window.location.href= "/Users/williambonner/Source/repos/TitleTownCatering/Client/resources/ManagerDashboard.html";
    } else {
        loginErrorMsg.style.opacity = 1;
    }
})