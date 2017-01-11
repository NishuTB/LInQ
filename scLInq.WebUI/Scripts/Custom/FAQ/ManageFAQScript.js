$(document).ready(function () {
    bindRequestGrid();
});


function bindRequestGrid() {

    var lastsel;

    debugger;
    $("#tblJQGrid").jqGrid({
        useColSpanStyle: true,
        url: "/FAQ/LoadManageFAQRequests",
        datatype: 'json',
        mtype: 'GET',
        colNames: ['Id', 'Question', 'Answer', 'AttachedToNode', 'CreatedBy', 'CreatedOn', 'ModifiedBy', 'ModifyOn'],
        colModel: [
                    { name: 'Id', index: 'Id', sorttype: 'int' },
                     { name: 'Question', index: 'Question',editable:true, fixed: true, sortable: false, formatter: QuestionButtons },
                     { name: 'Answer', index: 'Answer', editable: true, },
                     //{
                     //    name: 'Answer', index: 'Answer', editable: true, edittype: "custom", editoptions: {
                     //        custom_element: function (value, options) {
                     //            var elm = $('<textarea></textarea>');
                     //            elm.val(value);
                     //            setTimeout(function () {
                     //                tinymce.init({ selector: "textarea#" + options.id });
                     //            }, 100);
                     //            return elm;
                     //        },
                     //        custom_value: function (element, oper, gridval) {
                     //            var id = element[0].Id;
                     //            if (oper == 'get') {
                     //                return tinymce.get(i).getContent({ format: 'row' });
                     //            } else if (oper == 'set') {
                     //                if (tinmce.get(id)) {
                     //                    tinymce.get(id).setContent(gridval);
                     //                }
                     //            }

                     //        }

                     //    }
                     //},

                     { name: 'AttachedToNode', index: 'AttachedToNode', editable: true, },
                    { name: 'CreatedBy', index: 'CreatedBy', editable: true, },
                      { name: 'CreatedOn', index: 'CreatedOn', editable: true, formatter: "date", formatoptions: { newformat: "m/d/Y" } },
                       { name: 'ModifiedBy', index: 'ModifiedBy', editable: true, },
                      { name: 'ModifyOn', index: 'ModifyOn', editable: true, formatter: "date", formatoptions: { newformat: "m/d/Y" } }

        ],

        onSelectRow: function (id) {
            if (id && id !== lastsel) {
                jQuery('#tblJQGrid').jqGrid('restoreRow', lastsel);
                jQuery('#tblJQGrid').jqGrid('editRow', id, true);
                lastsel = id;
            }
        },

       pager: jQuery('#pager'),
        rowNum: 5,
        height: '100%',
        sortorder: "desc",
        viewrecords: true,
        loadonce: true,
        scrollOffset: 0,
        shrinkToFit: false,
        sortable: true,

        editurl: "server.php",

        emptyrecords: 'No records to display',
        jsonReader: { repeatitems: false, id: "Id" },
        autowidth: true,
        onInitGrid: function () {
            var objHeader = $("#tblJQGrid .jqgfirstrow td");
            $(objHeader[0]).html("<span class='ui-jqgrid-resize ui-jqgrid-resize-ltr' style='cursor: col-resize;'></span><div id='jqgh_tblJQGrid_Id' class='ui-jqgrid-sortable'>Sr. NO.<span style='' class='s-ico'><span class='ui-grid-ico-sort ui-icon-asc ui-state-disabled ui-icon ui-icon-triangle-1-n ui-sort-ltr' sort='asc'></span><span class='ui-grid-ico-sort ui-icon-desc ui-icon ui-icon-triangle-1-s ui-sort-ltr' sort='desc'></span></span></div>");
            $(objHeader[0]).css("width", "20px");
            $(objHeader[1]).html("<span class='ui-jqgrid-resize ui-jqgrid-resize-ltr' style='cursor: col-resize;'></span><div id='jqgh_tblJQGrid_Question' class='ui-jqgrid-sortable'>Question<span style='' class='s-ico'><span class='ui-grid-ico-sort ui-icon-asc ui-state-disabled ui-icon ui-icon-triangle-1-n ui-sort-ltr' sort='asc'></span><span class='ui-grid-ico-sort ui-icon-desc ui-icon ui-icon-triangle-1-s ui-sort-ltr' sort='desc'></span></span></div>");
            $(objHeader[1]).css("width", "30px");
            $(objHeader[2]).html("<span class='ui-jqgrid-resize ui-jqgrid-resize-ltr' style='cursor: col-resize;'></span><div id='jqgh_tblJQGrid_Answer' class='ui-jqgrid-sortable'>Answer<span style='' class='s-ico'><span class='ui-grid-ico-sort ui-icon-asc ui-state-disabled ui-icon ui-icon-triangle-1-n ui-sort-ltr' sort='asc'></span><span class='ui-grid-ico-sort ui-icon-desc ui-icon ui-icon-triangle-1-s ui-sort-ltr' sort='desc'></span></span></div>");
            $(objHeader[2]).css("width", "30px");
            $(objHeader[3]).html("<span class='ui-jqgrid-resize ui-jqgrid-resize-ltr' style='cursor: col-resize;'></span><div id='jqgh_tblJQGrid_AttachedToNode' class='ui-jqgrid-sortable'>Attached To Node<span style='' class='s-ico'><span class='ui-grid-ico-sort ui-icon-asc ui-state-disabled ui-icon ui-icon-triangle-1-n ui-sort-ltr' sort='asc'></span><span class='ui-grid-ico-sort ui-icon-desc ui-icon ui-icon-triangle-1-s ui-sort-ltr' sort='desc'></span></span></div>");
            $(objHeader[3]).css("width", "30px");
            $(objHeader[4]).html("<span class='ui-jqgrid-resize ui-jqgrid-resize-ltr' style='cursor: col-resize;'></span><div id='jqgh_tblJQGrid_CreatedBy' class='ui-jqgrid-sortable'>Created By<span style='' class='s-ico'><span class='ui-grid-ico-sort ui-icon-asc ui-state-disabled ui-icon ui-icon-triangle-1-n ui-sort-ltr' sort='asc'></span><span class='ui-grid-ico-sort ui-icon-desc ui-icon ui-icon-triangle-1-s ui-sort-ltr' sort='desc'></span></span></div>");
            $(objHeader[4]).css("width", "30px");
            $(objHeader[5]).html("<span class='ui-jqgrid-resize ui-jqgrid-resize-ltr' style='cursor: col-resize;'></span><div id='jqgh_tblJQGrid_CreatedOn' class='ui-jqgrid-sortable'>Created On<span style='' class='s-ico'><span class='ui-grid-ico-sort ui-icon-asc ui-state-disabled ui-icon ui-icon-triangle-1-n ui-sort-ltr' sort='asc'></span><span class='ui-grid-ico-sort ui-icon-desc ui-icon ui-icon-triangle-1-s ui-sort-ltr' sort='desc'></span></span></div>");
            $(objHeader[5]).css("width", "30px");
            $(objHeader[6]).html("<span class='ui-jqgrid-resize ui-jqgrid-resize-ltr' style='cursor: col-resize;'></span><div id='jqgh_tblJQGrid_ModifiedBy' class='ui-jqgrid-sortable'>Modified By<span style='' class='s-ico'><span class='ui-grid-ico-sort ui-icon-asc ui-state-disabled ui-icon ui-icon-triangle-1-n ui-sort-ltr' sort='asc'></span><span class='ui-grid-ico-sort ui-icon-desc ui-icon ui-icon-triangle-1-s ui-sort-ltr' sort='desc'></span></span></div>");
            $(objHeader[6]).css("width", "30px");
            $(objHeader[7]).html("<span class='ui-jqgrid-resize ui-jqgrid-resize-ltr' style='cursor: col-resize;'></span><div id='jqgh_tblJQGrid_ModifyOn' class='ui-jqgrid-sortable'>Modify On<span style='' class='s-ico'><span class='ui-grid-ico-sort ui-icon-asc ui-state-disabled ui-icon ui-icon-triangle-1-n ui-sort-ltr' sort='asc'></span><span class='ui-grid-ico-sort ui-icon-desc ui-icon ui-icon-triangle-1-s ui-sort-ltr' sort='desc'></span></span></div>");
            $(objHeader[7]).css("width", "30px");
        }
    });

}


var getQuestion;

function QuestionButtons(cellvalue, options, rowObject) {
    getQuestion = rowObject.Question;
    var x = "<a onclick=\"Question('" + options.rowId + "');\">" + rowObject.Question + "</a>";
    return x;
}

function Question(ID) {
    var rowData = $("#tblJQGrid").getRowData(ID);
    alert("Question : " + getQuestion + "\n Answer:" + rowData.Answer);
}