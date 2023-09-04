﻿$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": { url: '/admin/product/getall' },
        "columns": [
            { data: 'title', "width": "15%" },
            { data: 'description', "width": "20%" },
            { data: 'foodName', "width": "15%" },
            { data: 'foodCode', "width": "15%" },
            { data: 'price', "width": "15%" },
            { data: 'category.name', "width": "15%" },
            {
                data: 'id',
                "render": function (data) {
                    return `<div class="w-100 btn-group" role="group">
                     <a href="/admin/product/upsert?id=${data}" class="btn btn-primary mx-2"> <i class="bi bi-pencil-square"></i> </a>               
                     <a href="/admin/product/delete/${data}" class="btn btn-danger mx-2"> <i class="bi bi-trash-fill"></i> </a>
                    </div>`
                },
                "width": "15%"
            }
        ]
    });
}