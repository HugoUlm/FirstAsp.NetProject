var pCost = document.getElementById('cost').innerHTML.replace(' KR', '');
var shipping = document.getElementById('shipping').innerHTML.replace(' KR', '');
var cost = parseInt(pCost);
var ship = parseInt(shipping);
var total = cost + ship;
document.getElementById("cost-text").innerHTML = total + ' KR';
