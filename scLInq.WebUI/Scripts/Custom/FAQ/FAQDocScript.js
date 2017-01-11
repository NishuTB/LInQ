$(document).ready(function () {
    bindRequestGrid();
});


function bindRequestGrid() {

    $("#tblJQGrid").jqGrid({
        useColSpanStyle: true,
        url: "/FAQ/LoadFAQRequests",
        datatype: 'json',
        mtype: 'GET',
        colNames: ['Id', 'Question','Answer'],
        colModel: [
                    { name: 'Id', index: 'Id', sorttype: 'int' },
                     { name: 'Question', index: 'Question', fixed: true, sortable: false, formatter: EditButtons },
                     { hidden: true, name: 'Answer', index: 'Answer'},

        ],
        //onSelectRow: function (id) { var rowData = $("#tblJQGrid").getRowData(id); debugger; alert("Question : " +rowData.Question +"\n Answer:"+  rowData.Answer) },
        pager: jQuery('#pager'),
        rowNum: 5,
        height: '100%',
        sortorder: "desc",
        viewrecords: true,
        loadonce: true,
        scrollOffset: 0,
        shrinkToFit: false,
        sortable: true,
        emptyrecords: 'No records to display',
        jsonReader: { repeatitems: false, id: "Id" },
        autowidth: true,
        onInitGrid: function () {
            var objHeader = $("#tblJQGrid .jqgfirstrow td");
            $(objHeader[0]).html("<span class='ui-jqgrid-resize ui-jqgrid-resize-ltr' style='cursor: col-resize;'></span><div id='jqgh_tblJQGrid_Id' class='ui-jqgrid-sortable'>Sr. NO.<span style='' class='s-ico'><span class='ui-grid-ico-sort ui-icon-asc ui-state-disabled ui-icon ui-icon-triangle-1-n ui-sort-ltr' sort='asc'></span><span class='ui-grid-ico-sort ui-icon-desc ui-icon ui-icon-triangle-1-s ui-sort-ltr' sort='desc'></span></span></div>");
            $(objHeader[0]).css("width", "50px");
            $(objHeader[1]).html("<span class='ui-jqgrid-resize ui-jqgrid-resize-ltr' style='cursor: col-resize;'></span><div id='jqgh_tblJQGrid_Question' class='ui-jqgrid-sortable'>Question<span style='' class='s-ico'><span class='ui-grid-ico-sort ui-icon-asc ui-state-disabled ui-icon ui-icon-triangle-1-n ui-sort-ltr' sort='asc'></span><span class='ui-grid-ico-sort ui-icon-desc ui-icon ui-icon-triangle-1-s ui-sort-ltr' sort='desc'></span></span></div>");
            $(objHeader[1]).css("width", "50px");
            $(objHeader[2]).html("<span class='ui-jqgrid-resize ui-jqgrid-resize-ltr' style='cursor: col-resize;'></span><div id='jqgh_tblJQGrid_Answer' class='ui-jqgrid-sortable'>Answer<span style='' class='s-ico'><span class='ui-grid-ico-sort ui-icon-asc ui-state-disabled ui-icon ui-icon-triangle-1-n ui-sort-ltr' sort='asc'></span><span class='ui-grid-ico-sort ui-icon-desc ui-icon ui-icon-triangle-1-s ui-sort-ltr' sort='desc'></span></span></div>");
            $(objHeader[2]).css("width", "50px");
        }
    });

    $("#tblJQGrid_FAQDoc").jqGrid({
        useColSpanStyle: true,
        url: "/FAQ/LoadFAQDocRequests",
        datatype: 'json',
        mtype: 'GET',
        colNames: ['Id', 'FAQDoc'],
        colModel: [
                    { name: 'Id', index: 'Id', sorttype: 'int' },
                    { name: 'FAQDoc', index: 'FAQDoc' },

        ],
        pager: jQuery('#pager1'),
        rowNum: 5,
        height: '100%',
        sortorder: "desc",
        viewrecords: true,
        loadonce: true,
        scrollOffset: 0,
        shrinkToFit: false,
        sortable: true,
        emptyrecords: 'No Document Found',       
        jsonReader: { repeatitems: false, id: "Id" },
        autowidth: true,
        onInitGrid: function () {
            var objHeader = $("#tblJQGrid_FAQDoc .jqgfirstrow td");
            $(objHeader[0]).html("<span class='ui-jqgrid-resize ui-jqgrid-resize-ltr' style='cursor: col-resize;'></span><div id='jqgh_tblJQGrid_FAQDoc_Id' class='ui-jqgrid-sortable'>Sr. NO.<span style='' class='s-ico'><span class='ui-grid-ico-sort ui-icon-asc ui-state-disabled ui-icon ui-icon-triangle-1-n ui-sort-ltr' sort='asc'></span><span class='ui-grid-ico-sort ui-icon-desc ui-icon ui-icon-triangle-1-s ui-sort-ltr' sort='desc'></span></span></div>");
            $(objHeader[0]).css("width", "20px");
            $(objHeader[1]).html("<span class='ui-jqgrid-resize ui-jqgrid-resize-ltr' style='cursor: col-resize;'></span><div id='jqgh_tblJQGrid_FAQDoc_FAQDoc' class='ui-jqgrid-sortable'>Documents<span style='' class='s-ico'><span class='ui-grid-ico-sort ui-icon-asc ui-state-disabled ui-icon ui-icon-triangle-1-n ui-sort-ltr' sort='asc'></span><span class='ui-grid-ico-sort ui-icon-desc ui-icon ui-icon-triangle-1-s ui-sort-ltr' sort='desc'></span></span></div>");
            $(objHeader[1]).css("width", "50px");
        }
    })
}


var getQuestion;

function EditButtons(cellvalue, options, rowObject) {
    getQuestion = rowObject.Question;
    var x = "<a onclick=\"Edit('" + options.rowId + "');\">" + rowObject.Question + "</a>";
    return x;
}

function Edit(ID) {
    var rowData = $("#tblJQGrid").getRowData(ID);
    alert("Question : " + getQuestion + "\n Answer:" + rowData.Answer);
}