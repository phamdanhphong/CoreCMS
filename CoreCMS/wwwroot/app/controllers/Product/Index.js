var ProductController = function() {
    this.initialize = function () {
        loadProductCategory();
        loadData();
        registerEvents();
    }

    function registerEvents( ) {
        $('#ddlShowPage').on('change', function () {
            cms.configs.pageSize = $(this).val();
            cms.configs.pageIndex = 1;
            loadData(true);
        });

        $('#btnSearch').on('click', function () {
            cms.configs.pageSize = $('#ddlShowPage').val();
            cms.configs.pageIndex = 1;
            loadData(true);
        });

        $('#txtKeyword').on('keypress', function (e) {
            if (e.which===13) {
                cms.configs.pageSize = $('#ddlShowPage').val();
                cms.configs.pageIndex = 1;
                loadData(true); 
            }
        });
       }

    function loadProductCategory() {
        var render = "";
        $.ajax({
            type: 'GET',
            url: '/admin/product/GetAllProductCate',
            dataType: 'json',
            success: function (response) {
                console.log(response); 
                render += "<option value=''>--Tất cả danh mục--</option>";
                $.each(response, function (i, item) {
                    render += "<option value='" + item.GroupId + "'>" + item.GroupName+"</option>";
                });
                if (render != "") {
                    $("#dlProductCate").html(render);
                }
            },
            error: function (status) {
                console.log(status);
                cms.notify('Cannot loading data', 'error');
            }

        });
    }

    function loadData(isPageChanged) {

        var template = $("#table-template").html();
        var render = "";
        $.ajax({
            type: 'GET',
            data: {
                groupId: $("#dlProductCate").val(),
                keyword: $('#txtKeyword').val(),
                page: cms.configs.pageIndex,
                pageSize: cms.configs.pageSize
            },
            url: '/admin/product/GetAllPagingByApp',
            dataType: 'json',
            success: function (response) {
                $.each(response.Results, function(i, item) {
                    render += Mustache.render(template, {
                        Number:i+1,
                        Id:item.ItemId,
                        Title: item.Title,
                        Image: item.Image == null ? '<img src="/admin-side/images/user.png"/>' : '<img width="90px" height="72px" src="/pic/product/' + item.Image+'"/>',
                        DateCreated: cms.dateTimeFormatJson(item.DateCreated),
                        TotalView: item.TotalView,
                        Status: cms.getStatus(item.ItemStatus)
                    });
                    if (render!="") {
                        $("#tbl-content").html(render);
                    }
                    wrapPaging(response.RowCount, function () {
                        loadData();
                    }, isPageChanged);
                });
            },
            error: function(status) {
                console.log(status);
                cms.notify('Cannot loading data', 'error');
            }

        });
    }
    function wrapPaging(recordCount, callBack, changePageSize) {
        var totalsize = Math.ceil(recordCount / cms.configs.pageSize);
        //Unbind pagination if it existed or click change pagesize
        if ($('#paginationUL a').length === 0 || changePageSize === true) {
            $('#paginationUL').empty();
            $('#paginationUL').removeData("twbs-pagination");
            $('#paginationUL').unbind("page");
        }
        //Bind Pagination Event
        $('#paginationUL').twbsPagination({
            totalPages: totalsize,
            visiblePages: 7,
            first: 'Đầu',
            prev: 'Trước',
            next: 'Tiếp',
            last: 'Cuối',
            onPageClick: function (event, p) {
                cms.configs.pageIndex = p;
                setTimeout(callBack(), 200);
            }
        });
    }
}
