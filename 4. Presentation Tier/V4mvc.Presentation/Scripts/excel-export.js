function export_download_xls(full_logo_path = null) {
    var styles = {
        'header_cell': "background-color: rgb(36, 123, 190); border-bottom-color: rgb(221,221,221); border-bottom-style: solid; border-bottom-width: 1px; border-collapse: collapse; border-image-outset: 0; border-image-repeat: stretch; border-image-slice: 100%; border-image-source: none; border-image-width: 1; border-left-color: rgb(231,231,231); border-left-style: solid; border-left-width: 1px; border-right-color: rgb(231,231,231); border-right-style: solid; border-right-width: 1px; border-top-color: rgb(255,255,255); border-top-style: none; border-top-width: 0px; box-sizing: border-box; color: rgb(255,255,255); display: table-cell; font-family: 'Open: Sans',sans-serif; font-size: 13px; font-weight: 700; height: 35.2px; line-height: 18.5714px; padding-bottom: 8px; padding-left: 8px; padding-right: 8px; padding-top: 8px; text-align: left; text-indent: 0px; text-size-adjust: 100%; vertical-align: top; width: 175.2px; -webkit-border-horizontal-spacing: 0px; -webkit-border-vertical-spacing: 0px; -webkit-tap-highlight-color: rgba(0,0,0,0)",
        'body_cell': "border-bottom-color: rgb(231,231,231); border-bottom-style: solid; border-bottom-width: 1px; border-collapse: collapse; border-image-outset: 0; border-image-repeat: stretch; border-image-slice: 100%; border-image-source: none; border-image-width: 1; border-left-color: rgb(231,231,231); border-left-style: solid; border-left-width: 1px; border-right-color: rgb(231,231,231); border-right-style: solid; border-right-width: 1px; border-top-color: rgb(231,234,236); border-top-style: solid; border-top-width: 1px; box-sizing: border-box; color: rgb(85,85,85); display: table-cell; font-family: 'Open: Sans',sans-serif; font-size: 13px; font-weight: 400; height: 35.2px; line-height: 18.5714px; padding-bottom: 8px; padding-left: 8px; padding-right: 8px; padding-top: 8px; text-align: -webkit-right; text-indent: 0px; text-size-adjust: 100%; vertical-align: middle; width: 292.8px; -webkit-border-horizontal-spacing: 0px; -webkit-border-vertical-spacing: 0px; -webkit-tap-highlight-color: rgba(0,0,0,0);",
        'footer_cell': "color: white;background-attachment: scroll; background-clip: border-box; background-color: rgb(57,137,198); background-image: none; background-origin: padding-box; background-position-x: 0%; background-position-y: 0%; background-repeat-x; background-repeat-y; background-size: auto; border-bottom-color: rgb(255,255,255); border-bottom-style: none; border-bottom-width: 0px; border-collapse: collapse; border-image-outset: 0; border-image-repeat: stretch; border-image-slice: 100%; border-image-source: none; border-image-width: 1; border-left-color: rgb(231,231,231); border-left-style: solid; border-left-width: 1px; border-right-color: rgb(231,231,231); border-right-style: solid; border-right-width: 1px; border-top-color: rgb(170,170,170); border-top-style: solid; border-top-width: 1px; box-sizing: border-box; color: rgb(255,255,255); display: table-cell; font-family: 'Open: Sans',sans-serif; font-size: 13px; font-weight: 400; height: 19.2px; line-height: 18.5714px; padding-bottom: 0px; padding-left: 8px; padding-right: 8px; padding-top: 0px; text-align: right; text-indent: 0px; text-size-adjust: 100%; vertical-align: top; white-space: nowrap; width: 292.8px; -webkit-border-horizontal-spacing: 0px; -webkit-border-vertical-spacing: 0px; -webkit-tap-highlight-color: rgba(0,0,0,0)",
        'tt_cell': "background-color: rgb(36, 123, 190); border-bottom-color: rgb(231,231,231); border-bottom-style: solid; border-bottom-width: 1px; border-collapse: collapse; border-image-outset: 0; border-image-repeat: stretch; border-image-slice: 100%; border-image-source: none; border-image-width: 1; border-left-color: rgb(231,231,231); border-left-style: solid; border-left-width: 1px; border-right-color: rgb(231,231,231); border-right-style: solid; border-right-width: 1px; border-top-color: rgb(231,234,236); border-top-style: solid; border-top-width: 1px; box-sizing: border-box; color: rgb(255,255,255); display: table-cell; font-family: 'Open: Sans',sans-serif; font-size: 13px; font-weight: 400; height: 35.2px; line-height: 18.5714px; padding-bottom: 8px; padding-left: 8px; padding-right: 8px; padding-top: 8px; text-indent: 0px; text-size-adjust: 100%; vertical-align: middle; width: 152px; -webkit-border-horizontal-spacing: 0px; -webkit-border-vertical-spacing: 0px; -webkit-tap-highlight-color: rgba(0,0,0,0);",
        'green_cell': "color:green;",
        'red_cell': "color:red;",
        'invoice-details': "box-sizing: border-box; color: rgb(85,85,85); display: block; float: left; font-family: 'Open: Sans',sans-serif; font-size: 13px; font-weight: 400; height: 100px; line-height: 18.5714px; min-height: 1px; padding-left: 15px; padding-right: 15px; position: relative; text-align: right; text-size-adjust: 100%; width: 100%; -webkit-tap-highlight-color: rgba(0,0,0,0);",
        'invoice-details h1': "box-sizing: border-box;color: rgb(57, 137, 198);display: block;font-family: 'Open: Sans', sans-serif;font-size: 30px;font-weight: 100;line-height: 50px;min-height: 70px;margin-block-end: 10px;margin-block-start: 0px;margin-bottom: 10px;margin-inline-end: 0px;margin-inline-start: 0px;margin-left: 0px;margin-right: 0px;margin-top: 0px;text-align: right;-webkit-tap-highlight-color: rgba(0, 0, 0, 0);"
    };
    var styled_sets = {
        'table.table thead th': 'header_cell',
        'table.table tbody td': 'body_cell',
        'table.table tfoot td': 'footer_cell',
        '.tituloTabla': 'tt_cell',
        '.span_verde': 'green_cell',
        '.span_rojo': 'red_cell',
        '.invoice-details': 'invoice-details'
    };
    if (window.jQuery) {
        var html_clone = $('html').clone();
        var img_logo = $('#img_informe', html_clone);
        var mime_type = 'application/vnd.ms-excel';
        var encoding = 'UTF-8';
        var rem_tags = ['button', 'link', 'style', 'script'];
        if (full_logo_path) {
            img_logo.attr('src', full_logo_path);
            img_logo.attr('height', 50);
        }
        else {
            img_logo.remove();
        }
        $(rem_tags.join(','), html_clone).remove();
        $('header, main, footer', html_clone).replaceWith(function () {
            return $("<div />").append($(this).contents());
        });
        $('meta[http-equiv="Content-Type"]', html_clone).attr('content', mime_type + ';charset=' + encoding);

        for (var sctor in styled_sets) {
            $(sctor, html_clone).attr('class1', styled_sets[sctor]);
        }
        var str_styles = '';
        for (var style in styles) {
            str_styles += '.' + style + '{' + styles[style] + '} '; 
        }
        $('head', html_clone).append($('<style>' + str_styles + '</style>'));

        var dom_str = html_clone[0].outerHTML;
        dom_str = dom_str.replace(/<\!--.*?-->/g, "").replace(/data-[^=]+="(.*?)"/gm, "").replace(/id="(.*?)"/gm, "").replace(/class="(.*?)"/gm, "").replace(/class1/gm, "class");
        dom_str = dom_str.replace(/[\s\n\r]+\</g, "<").replace(/\>[\s\n\r]+\</g, "><").replace(/\>[\s\n\r]+$/g, ">"); //important!: if dom_string length > 2Mb; security does not allow downloading
        dom_str = replaceSpaChars(dom_str);
        window.open('data:' + mime_type + '; charset=' + encoding + ',' + encodeURIComponent(dom_str));
    }
}