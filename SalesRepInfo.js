function getSalesForSaleRep(id) {
        // ajax request to the RESTful web service
    $.ajax({
        type: 'GET',
        url: 'http://localhost:49822/api/vendedores/' + id.toString() + '/orders',
        success: getSalesForSaleRepHandler,
        error: function () {
            console.log("Request failed!");
        }
    });
}



function getSalesForSaleRepHandler(data) {

    // debug
    console.log("Request Successful!");
    console.log(data);
    
	$('.sale-products-list').html('');
    for (i = 0; i < data.length; i++) {
		var rep = data[i];
		for (j = 0; j < rep.products.length; j++) {
			
			var products = rep.products[j];
			var html =
				'<div class="sale-item id="' + products.productId +' ">'
					  +  '<div class="sale-item-text">'
					  +  '<h4 class="sale-item-name">' + products.productId + '</h4>'
					  +   '<div class="sale-information">'
					  +     '     <span class="sale-quantity"> Quantity: ' + products.quantity + '</span>'
					  +     '     <span class="sale-date"> Date: ' + rep.orderDate + '</span>'
					  +     '     <span class="sale-customer"> Customer: ' + rep.customerId + '</span>'
					  +     ' </div> ' 
				   +    ' </div>'
				   +' </div>';
				
				$('.sale-products-list').append(html);
		}
	
	}
}

function getProductById(id) {
        // ajax request to the RESTful web service
    $.ajax({
        type: 'GET',
        url: 'http://localhost:49822/api/artigos/' + id.toString(),
        success: getProductHandler,
        error: function () {
            console.log("Request failed!");
        }
    });
}

function getProductHandler(data) {

    // debug
    console.log("Request Successful!");
    console.log(data);
    
	var product = data.DescArtigo;

}




function getSalesRepById(id) {
        // ajax request to the RESTful web service
    $.ajax({
        type: 'GET',
        url: 'http://localhost:49822/api/vendedores/' + id.toString(),
        success: getSalesRepByIdHandler,
        error: function () {
            console.log("Request failed!");
        }
    });
}



function getSalesRepByIdHandler(data) {

    // debug
    console.log("Request Successful!");
    console.log(data);

    var rep = data;
    var generalInfo = 
        '<h4 class= "s-name">' + rep.name.substring(0, 31) + '</h4>'
        + '<p class="s-address">' + rep.address + '</p>'
        + '<p class="s-zip">' + rep.zip + '</p>';

    var info =  
        '<p class="phone"> Phone: ' + rep.phone + '</p>'
        + '<p class="email"> Email: ' + rep.email + '</p>'
        + '<p class="fiscal-id"> Fiscal ID: ' + rep.fiscalID + '</p>'
            + '<div class="sale-rep-info-last-row">'
            + '<p class="birth-date"> Birth Date: ' + rep.birthDate + '</p>'
                + '<button type="button" class="btn btn-default edit-button">Edit</button>'
            + '</div>';

    var description = rep.description;

    var picture = rep.picture;
    var defaultPath = 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSf2u0RWmYALKJ431XNoTKjzu77ERLBIvXKlOEA-Q3DPo2h2rCB';

    //Checks if the source path is valid before setting the image
    if(picture != '')
    {
        var obj = new Image();
        obj.src = picture;
        if(obj.complete){
            $('.sale-rep-profile-image').attr('src', picture);
        }
        else
            $('.sale-rep-profile-image').attr('src', defaultPath);
    }
    else
        $('.sale-rep-profile-image').attr('src', defaultPath);

    $('.sale-rep-general-info').html(generalInfo);
    $('.sale-rep-info').html(info);
    $('.sale-rep-description-text').html(description);
}

/**
* Gets all reps and update html to show them
*/
function getAllSalesReps() {

    // ajax request to the RESTful web service
    $.ajax({
        type: 'GET',
        url: 'http://localhost:49822/api/vendedores/',
        success: getAllSalesRepsHandler,
        error: function () {
            console.log("Request failed!");
        }
    });
}


/**
* Updates html to show sales reps list
*
* @param data JSON response sent by the RESTful web service
*/
function getAllSalesRepsHandler(data) {

    // debug
    console.log("Request Successful!");
    console.log(data);
    
    for (i = 0; i < data.length; i++) {

        var rep = data[i];
        var html =
            '<div class="sale-rep-item" id="' + rep.repId +'">'
                + '<div class="sale-rep-item-text">'
                + '<h4 class="sale-rep-name">' + rep.name + '</h4>'
                        +  '<div class="sale-rep-information">'
                            + '<span class="sale-number"> Sales: ' + rep.sales + '</span>'
                        + '</div>'
                    + '</div>'
                + '</div>';

        $('.sale-rep-list').append(html);
    }

}


/**
* Main
*/
$(document).ready(function () {

    getAllSalesReps();


});

$(".sale-rep-list").click(function(event) {
    var rep = $(event.target);
	

    //Finds root element
    while(!rep.hasClass('sale-rep-item'))
        rep = rep.parent();

    //Resets previous clicked elements
    var active = $(".sale-rep-list").find('.active');
    for(var i = 0; i < active.length; i++)
        $(active[i]).removeClass('active');

    //Sets current element as active
    rep.addClass('active');

    var id = rep.attr('id')
    getSalesRepById(id);
	getSalesForSaleRep(3);
	
});
