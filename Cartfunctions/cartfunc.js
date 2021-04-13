function getCart(){
    const allCartAPIURL = "placeholder";

    fetch(allCartAPIURL).then(function(response){
        return response.json();
    }).then(function(json){
        let html = "<ul>";
        json.forEach((CartItem)=>{
            html += "<li>" +CartItem.itemdescription,
            html += "<button onclick=\"addItem("+Cart.cartid+")\">+</button>",
            html += "<button onclick=\"deleteItem("+Cart.cartid+")\">-</button>" + "</li>"
        })
        html += "</ul>";
        document.getElementById("cartitems").innerHTML = html;
    }).catch(function(error){
        console.log(error);
    })
}
function addCart(){
    const addCartAPIURL = "placeholder";
    const
}