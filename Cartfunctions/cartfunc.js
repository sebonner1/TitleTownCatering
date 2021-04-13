function getCart(){
    const allCartAPIURL = "placeholder";

    fetch(allCartAPIURL).then(function(response){
        return response.json();
    }).then(function(json){
        let html = "<ul>";
        json.forEach((CartItem)=>{
            html += "<li>" +"<button onclick=\"addItem("+Cart.cartid+")\">+</button>",
            html += CartItem.itemdescription,
            html += "<button onclick=\"deleteItem("+Cart.cartid+")\">-</button>" + "</li>"
        })
        html += "</ul>";
        document.getElementById("cartitems").innerHTML = html;
    }).catch(function(error){
        console.log(error);
    })
}
function addCart(cartid){
    const addCartAPIURL = "placeholder" + cartid;
    console.log(cartid);
    
    fetch(addCartAPIURL, {
        method: "POST",
        headers: {
            "Accept": 'application/json',
            "Content-Type": 'application/json'
        }
    }).then((response)=>{
        console.log(response);
        getCart();
    })
}
function delCart(cartid){
    const delCartAPIURL = "placeholder" + cartid;
    console.log(cartid);
    
    fetch(delCartAPIURL, {
        method: "DELETE",
        headers: {
            "Accept": 'application/json',
            "Content-Type": 'application/json'
        }
    }).then((response)=>{
        console.log(response);
        getCart();
    })
}