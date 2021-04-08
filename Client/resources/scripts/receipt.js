const checkoutbutton = document.getElementById("checkoutbutton");

// the below syntax from research
checkoutbutton.addEventListener("click", (e) => {
    alert("You are being directed to the calendar.");
    window.location.href= "/Users/williambonner/Source/repos/TitleTownCatering/Client/resources/Calendar.html";
})