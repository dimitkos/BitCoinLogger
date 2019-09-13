var container = $('div.container');

$('input#get').click(function () {


    $.ajax({
        type: 'GET',
        url: 'api/bitcoin/getBitstampData',
        dataType: 'json',
        success: function (data) {
            //$.each(data,function(index,item){
            //    $.each(item,function(key,value){
            //        container.append(key+': ' + value +'</br>');
            //    });
            //    container.append('<br/><br>')
            //})
            $.each(data, function (item, value) {
                //$.each(item,function(key,value){
                //    container.append(key+': ' + value +'</br>');
                //});
                container.append(item + ' ' + value + '</br >')
            })

        }
    });
})


var containerGdax = $('div.containerGdax');

$('input#getGdax').click(function () {


    $.ajax({
        type: 'GET',
        url: 'api/bitcoin/getGdaxData',
        dataType: 'json',
        success: function (data) {
            //$.each(data,function(index,item){
            //    $.each(item,function(key,value){
            //        container.append(key+': ' + value +'</br>');
            //    });
            //    container.append('<br/><br>')
            //})
            $.each(data, function (item, value) {
                //$.each(item,function(key,value){
                //    container.append(key+': ' + value +'</br>');
                //});
                containerGdax.append(item + ' ' + value + '</br >')
            })

        }
    });
})


var containerPrice = $('div.Pricecontainer');

$('input#getPrice').click(function () {


    $.ajax({
        type: 'GET',
        url: 'api/bitcoin/getBitstampData',
        dataType: 'json',
        success: function (data) {
            containerPrice.append(parseFloat(data.last).toFixed(2) + ' ' + '</br >')

        }
    });
})


var containerGdaxPrice = $('div.PriceGdaxcontainer');

$('input#getPriceGdax').click(function () {


    $.ajax({
        type: 'GET',
        url: 'api/bitcoin/getGdaxData',
        dataType: 'json',
        success: function (data) {
            containerGdaxPrice.append(parseFloat(data.price).toFixed(2) + ' ' + '</br >')

        }
    });
})

$('input#btn').click(function () {


    $.ajax({
        type: 'GET',
        url: 'api/bitcoin/getBitstampData',
        dataType: 'json',
        success: function (data) {

            var table = document.getElementById("myTable");
            var row = table.insertRow(0);
            var cell1 = row.insertCell(0);
            var cell2 = row.insertCell(1);
            var cell3 = row.insertCell(2);
            cell1.innerHTML = 'Source Bitstamp';
            cell2.innerHTML = parseFloat(data.last).toFixed(2);
            cell3.innerHTML = data.timestamp;
        }
    });

    $.ajax({
        type: 'GET',
        url: 'api/bitcoin/getGdaxData',
        dataType: 'json',
        success: function (data) {

            var table = document.getElementById("myTable");
            var row = table.insertRow(0);
            var cell1 = row.insertCell(0);
            var cell2 = row.insertCell(1);
            var cell3 = row.insertCell(2);
            cell1.innerHTML = 'Source Gdax';
            cell2.innerHTML = parseFloat(data.price).toFixed(2);
            cell3.innerHTML = data.time;
        }
    });
})





$('th').click(function () {
    var table = $(this).parents('table').eq(0)
    var rows = table.find('tr:gt(0)').toArray().sort(comparer($(this).index()))
    this.asc = !this.asc
    if (!this.asc) { rows = rows.reverse() }
    for (var i = 0; i < rows.length; i++) { table.append(rows[i]) }
})
function comparer(index) {
    return function (a, b) {
        var valA = getCellValue(a, index), valB = getCellValue(b, index)
        return $.isNumeric(valA) && $.isNumeric(valB) ? valA - valB : valA.toString().localeCompare(valB)
    }
}
function getCellValue(row, index) { return $(row).children('td').eq(index).text() }

function myFunction() {
    var input, filter, table, tr, td, i, txtValue;
    input = document.getElementById("myInput");
    filter = input.value.toUpperCase();
    table = document.getElementById("myTable");
    tr = table.getElementsByTagName("tr");
    for (i = 0; i < tr.length; i++) {
        td = tr[i].getElementsByTagName("td")[0];
        if (td) {
            txtValue = td.textContent || td.innerText;
            if (txtValue.toUpperCase().indexOf(filter) > -1) {
                tr[i].style.display = "";
            } else {
                tr[i].style.display = "none";
            }
        }
    }
}