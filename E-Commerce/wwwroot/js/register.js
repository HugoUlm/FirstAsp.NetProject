//function Snackbar(customer) {
//    if (customer.EmailAddress == null || customer.Password == null || customer.FirstName == null || customer.LastName == null || customer.Country == null || customer.Birth == "01/01/0001 00:00:00" || customer.Gender == null) {
//        // Get the snackbar DIV
//        var x = document.getElementById("snackbar-error");

//        // Add the "show" class to DIV
//        x.className = "show";

//        // After 3 seconds, remove the show class from DIV
//        setTimeout(function () { x.className = x.className.replace("show", ""); }, 3000);
//    }
//    if (customer.EmailAddress != null && customer.Password != null && customer.FirstName != null && customer.LastName != null && customer.Country != null && customer.Birth != "01/01/0001 00:00:00" && customer.Gender != null) {
//        // Get the snackbar DIV
//        var x = document.getElementById("snackbar-success");

//        // Add the "show" class to DIV
//        x.className = "show";

//        // After 3 seconds, remove the show class from DIV
//        setTimeout(function () { x.className = x.className.replace("show", ""); }, 3000);
//    }
//}

function Test() {
    var form = document.forms["form"].value;


    if (!form) {
        // Get the snackbar DIV
        var x = document.getElementById("snackbar-error");

        // Add the "show" class to DIV
        x.className = "show";

        // After 3 seconds, remove the show class from DIV
        setTimeout(function () { x.className = x.className.replace("show", ""); }, 3000);
    }
    else {
        // Get the snackbar DIV
        var x = document.getElementById("snackbar-success");

        // Add the "show" class to DIV
        x.className = "show";

        // After 3 seconds, remove the show class from DIV
        setTimeout(function () { x.className = x.className.replace("show", ""); }, 3000);
    }
}