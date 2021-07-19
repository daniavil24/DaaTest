
function LocalRegiones() {
    RenderTableRegiones();
}


function RenderTableRegiones() {
    var TablaRegiones = $("#GridRegiones").DataTable({
        dom: 'Bfrtip',
        pageLength: 10,
        columns: [
            { data: "name" },
            { data: "confirmed" },
            { data: "deaths" }
        ],
        buttons: [
            {
                text: 'JSON',
                action: function (e, dt, button, config) {
                    var data = dt.buttons.exportData();

                    $.fn.dataTable.fileSave(
                        new Blob([JSON.stringify(data)]),
                        'Export.json'
                    );
                }
            },
            'csv'
        ]
        //fixedColumns: true
    });
}