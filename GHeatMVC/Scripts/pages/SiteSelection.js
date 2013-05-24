var SiteSelection = {

    Init: function () {
        var self = this;

        var pathname = window.location.pathname;

        $(function () {
            $('#site-selection .site-selection-item').each(function () {
                var linkpath = $(this).find('.link').attr('href');
                if (pathname == linkpath) {
                    $(this).addClass('active');
                }
            });
        });
    }

};

SiteSelection.Init();