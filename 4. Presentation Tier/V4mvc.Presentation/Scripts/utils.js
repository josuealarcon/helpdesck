function FiltrarItems(id,tipo) {
    var filter, tag, valorfiltrado, i;
    filter = $('.filter-li-'+id).val().toUpperCase();
    tag = $(".filter-" + id).children();
    for (i = (tipo == 0 ? 1 : 0); i < tag.length; i++) {
        var valor = tag[i].getElementsByTagName("span")[0];
        if (valor != undefined)
            valorfiltrado = valor.innerHTML;
        else
            valorfiltrado = tag[i].getElementsByTagName("a")[0].text;
        if (valorfiltrado.toUpperCase().indexOf(filter) > -1) {
            tag[i].style.display = "";
        } else {
            tag[i].style.display = "none";
        }
    }
}

function setCookie(name, value, days) {
    var expires = "";
    if (days) {
        var date = new Date();
        date.setTime(date.getTime() + (days * 24 * 60 * 60 * 1000));
        expires = "; expires=" + date.toUTCString();
    }
    document.cookie = name + "=" + (value || "") + expires + "; path=/";
}

function getCookie(name) {
    var nameEQ = name + "=";
    var ca = document.cookie.split(';');
    for (var i = 0; i < ca.length; i++) {
        var c = ca[i];
        while (c.charAt(0) == ' ') c = c.substring(1, c.length);
        if (c.indexOf(nameEQ) == 0) return c.substring(nameEQ.length, c.length);
    }
    return null;
}
function eraseCookie(name) {
    document.cookie = name + '=; Path=/; Expires=Thu, 01 Jan 1970 00:00:01 GMT;';
}

/*rut con el formato simple: XXXXXXXXX*/
function es_rut_basico(valor) {
    function dv(T) {
        var M = 0, S = 1;
        for (; T; T = Math.floor(T / 10))
            S = (S + T % 10 * (9 - M++ % 6)) % 11;
        return S ? S - 1 : 'k';
    }
    if (!/^[0-9]+[0-9kK]{1}$/.test(valor))
        return false;
    var digv = valor.substring(valor.length - 1);
    var rut = valor.substring(0, valor.length - 1);
    if (digv == 'K') digv = 'k';
    return (dv(rut) == digv);
}

function es_dni_basico(valor) {
    return false;
}

function es_documento_identidad(valor, pais) {
    if (is_empty(pais)) {
        pais = 'CH';
    }
    var ret = false;
    if (pais == 'CH') {
        ret = es_rut_basico(valor);
    }
    else if (pais == 'PE') {
        ret = es_dni_basico(valor);
    }
    return ret;
}

function removeCharacter(str, chr) {
    var ret = str;
    if (not_empty(str) && is_string(str)) {
        ret = str.split(chr).join('');
    }
    return ret;
}

function insert(str, index, value) {
    return str.substr(0, index) + value + str.substr(index);
}

function add_zero(value) {
    return (value < 10 ? '0' + value : '' + value);
}

function arrayFirstIndexOf(array, predicate, predicateOwner) {
    for (var i = 0, j = array.length; i < j; i++) {
        if (predicate.call(predicateOwner, array[i])) {
            return i;
        }
    }
    return -1;
}

function getMeses(lan) {
    var meses = [
        { '0': 'Ene', '1': 'Jan' },
        { '0': 'Feb', '1': 'Feb' },
        { '0': 'Mar', '1': 'Mar' },
        { '0': 'Abr', '1': 'Apr' },
        { '0': 'May', '1': 'May' },
        { '0': 'Jun', '1': 'Jun' },
        { '0': 'Jul', '1': 'Jul' },
        { '0': 'Ago', '1': 'Ago' },
        { '0': 'Set', '1': 'Sep' },
        { '0': 'Oct', '1': 'Oct' },
        { '0': 'Nov', '1': 'Nov' },
        { '0': 'Dic', '1': 'Dec' }
    ];
    if (is_empty(lan)) {
        lan = 0;
    }
    return $.map(meses, function (val, i) {
        return val[lan];
    });

}

function reverse(s) {
    return s.split("").reverse().join("");
}

function formatRawPeriod(value, format, lan) {
    if (is_empty(format)) {
        format = 0;
    }
    if (is_empty(lan)) {
        lan = 0;
    }
    var ret = value;
    var months = [
        { '0': 'Ene', '1': 'Jan' },
        { '0': 'Feb', '1': 'Feb' },
        { '0': 'Mar', '1': 'Mar' },
        { '0': 'Abr', '1': 'Apr' },
        { '0': 'May', '1': 'May' },
        { '0': 'Jun', '1': 'Jun' },
        { '0': 'Jul', '1': 'Jul' },
        { '0': 'Ago', '1': 'Ago' },
        { '0': 'Set', '1': 'Sep' },
        { '0': 'Oct', '1': 'Oct' },
        { '0': 'Nov', '1': 'Nov' },
        { '0': 'Dic', '1': 'Dec' }
    ];
    if (value && !isNaN(value)) { /*is integer: str or num*/
        value = value + '';
        if (format === 0) { // dd-mm
            ret = insert(value, 4, '-');
        }
        else if (format === 1) { // month-yyyy
            var month = months[parseInt(value.substr(4, 2)) - 1][lan];
            var year = parseInt(value.substr(0, 4));
            ret = month + '-' + year;
        }
    }
    return ret;
}

function formatRawDate(value, format, lan) {
    if (is_empty(format)) {
        format = 0;
    }
    if (is_empty(lan)) {
        lan = 0;
    }
    var ret = value;
    var months = [
        { '0': 'Ene', '1': 'Jan' },
        { '0': 'Feb', '1': 'Feb' },
        { '0': 'Mar', '1': 'Mar' },
        { '0': 'Abr', '1': 'Apr' },
        { '0': 'May', '1': 'May' },
        { '0': 'Jun', '1': 'Jun' },
        { '0': 'Jul', '1': 'Jul' },
        { '0': 'Ago', '1': 'Ago' },
        { '0': 'Set', '1': 'Sep' },
        { '0': 'Oct', '1': 'Oct' },
        { '0': 'Nov', '1': 'Nov' },
        { '0': 'Dic', '1': 'Dec' }
    ];
    if (value && !isNaN(value)) { /*is integer: str or num*/
        value = value + '';
        if (format === 0) { // ddmmyyyy --> dd-mm-yyyy
            ret = insert(insert(value, 4, '-'), 7, '-');
        }
        else if (format === 1) { // ddmmyyyy --> dd-month-yyyy
            var day = parseInt(value.substr(6, 2));
            var month = months[parseInt(value.substr(4, 2)) - 1][lan];
            var year = parseInt(value.substr(0, 4));
            ret = add_zero(day) + '-' + month + '-' + year;
        }
        else if (format === 2) { // ddmmyyyy --> yyyymmdd
            var day = value.substr(0, 2);
            var month = value.substr(2, 2);
            var year = value.substr(4, 4);
            ret = year + month + day;
        }
    }
    return ret;
}

function formatTime(value, format) {
    var ret = value;
    if (is_empty(format)) {
        format = 0;
    }

    if (format == 0) { //hh:mi:ss -> hh:mi
        var pieces = value.split(':');
        ret = pieces[0] + ':' + pieces[1];
    }
    return ret;
}

function replaceAll(string, search, replace) {
    return string.split(search).join(replace);
}

function is_string(value) {
    return (typeof value === 'string' || value instanceof String);
}

function not_empty(value) {
    var empty = typeof value == 'undefined' || value == null || (is_string(value) && value.trim() == '');
    return !empty;
}

function is_empty(value) {
    return !not_empty(value);
}

function custom_format() {
    var str = arguments[0];
    for (var i = 1; i < arguments.length; i++) {
        var value = arguments[i];
        var key = '{{' + (i - 1) + '}}';
        str = replaceAll(str, key, value);
    }
    return str;
}

function tryJsonParse(value) {
    var ret_obj = null;
    if (not_empty(value)) {
        try {
            ret_obj = JSON.parse(value);
        }
        catch (e) {
            console.log(e);
        }
    }
    return ret_obj;
}

function fieldOrDefault(obj, field, _default) {
    var ret = _default;
    if (not_empty(obj) && obj.hasOwnProperty(field)) {
        ret = obj[field];
    }
    return ret;
}

function isInt(value) {
    return !isNaN(value) &&
        parseInt(Number(value)) == value &&
        !isNaN(parseInt(value, 10));
}

function removeFromArray(arr, value) { //remove all occurrences of such item from array
    var i = 0;
    while (i < arr.length) {
        if (arr[i] === value) {
            arr.splice(i, 1);
        } else {
            ++i;
        }
    }
    return arr;
}

function strRut(rut) {
    function agregar_puntos_miles(str_num) {
        var ret = "";
        try {
            var num_nuevo = "";
            var largo = str_num.length - 1;
            for (var i = 0; i < str_num.length; ++i) {
                if (i % 3 == 0 && i > 0) {
                    num_nuevo = num_nuevo + ".";
                }
                num_nuevo = num_nuevo + str_num[largo];
                --largo;
            }
            ret = num_nuevo.split("").reverse().join("");
        }
        catch (e) {
            ret = "";
        }
        return ret;
    }

    if (is_empty(rut)) {
        return rut;
    }
    var str = rut;

    try {
        var cabeza = rut.substring(0, rut.length - 1);
        if (isInt(cabeza)) {
            outnum = parseInt(cabeza);
            cabeza = agregar_puntos_miles(cabeza);
        }
        var cola = rut[rut.length - 1];
        str = cabeza + "-" + cola;
    }
    catch (e) {
        str = "";
    }
    return str;
}

function formatPatente(patente) {
    var idx_letter = -1;
    var str = patente;
    for (var i = patente.length - 1; i >= 0; --i) {
        if (!isInt(patente[i])) {
            idx_letter = i;
            break;
        }
    }
    if (idx_letter != -1) {
        str = patente.substring(0, idx_letter + 1) + '-' + patente.substring(idx_letter + 1);
    }
    return str;
}

function replaceSpaChars(s) {
    if (is_empty(s.normalize)) {
        return s;
    }
    return s.normalize("NFD").replace(/[\u0300-\u036f]/g, "");
}

function get_extension(value) {
    return value.substring(value.lastIndexOf(".") + 1);
}

function ROT13(input) {
    if (is_empty(input)) {
        return input;
    }
    var output = '';
    for (var i = 0; i < input.length; ++i) {
        var s = input[i].charCodeAt(0);
        if (s >= 97 && s <= 122) {
            if (s + 13 > 122) {
                s -= 13;
            }
            else {
                s += 13;
            }
        }
        else {
            if (s >= 65 && s <= 90) {
                if (s + 13 > 90) {
                    s -= 13;
                }
                else {
                    s += 13;
                }
            }
        }
        output += String.fromCharCode(s);
    }

    return output;

}

function lightweightEncrypt(input) {
    function b64_enc_fn(input_str) {
        if (window.btoa) {
            return window.btoa(input_str);
        } else { //for <= IE9
            return $.base64.btoa(input_str);
        }
    }
    return not_empty(input) ? b64_enc_fn(ROT13(input)) : input;
}

function lightweightDecrypt(input) {
    function b64_dec_fn(input_str) {
        if (window.atob) {
            return window.atob(input_str);
        } else { //for <= IE9
            return $.base64.atob(input_str);
        }
    }

    return not_empty(input) ? ROT13(b64_dec_fn(input)) : input;
}


function get_ext_from_mime(mime_type) {
    var mimes = {
        "text/html": "html",
        "text/css": "css",
        "text/xml": "xml",
        "image/gif": "gif",
        "image/jpeg": "jpeg",
        "application/x-javascript": "js",
        "application/atom+xml": "atom",
        "application/rss+xml": "rss",
        "text/mathml": "mml",
        "text/plain": "txt",
        "text/vnd.sun.j2me.app-descriptor": "jad",
        "text/vnd.wap.wml": "wml",
        "text/x-component": "htc",
        "image/png": "png",
        "image/tiff": "tiff",
        "image/vnd.wap.wbmp": "wbmp",
        "image/x-icon": "ico",
        "image/x-jng": "jng",
        "image/x-ms-bmp": "bmp",
        "image/svg+xml": "svg",
        "image/webp": "webp",
        "application/java-archive": "jar",
        "application/mac-binhex40": "hqx",
        "application/msword": "doc",
        "application/pdf": "pdf",
        "application/postscript": "ps",
        "application/rtf": "rtf",
        "application/vnd.ms-excel": "xls",
        "application/vnd.ms-powerpoint": "ppt",
        "application/vnd.wap.wmlc": "wmlc",
        "application/vnd.google-earth.kml+xml": "kml",
        "application/vnd.google-earth.kmz": "kmz",
        "application/x-7z-compressed": "7z",
        "application/x-cocoa": "cco",
        "application/x-java-archive-diff": "jardiff",
        "application/x-java-jnlp-file": "jnlp",
        "application/x-makeself": "run",
        "application/x-perl": "pl",
        "application/x-pilot": "pdb",
        "application/x-rar-compressed": "rar",
        "application/x-redhat-package-manager": "rpm",
        "application/x-sea": "sea",
        "application/x-shockwave-flash": "swf",
        "application/x-stuffit": "sit",
        "application/x-tcl": "tcl",
        "application/x-x509-ca-cert": "crt",
        "application/x-xpinstall": "xpi",
        "application/xhtml+xml": "xhtml",
        "application/zip": "zip",
        "audio/midi": "midi",
        "audio/mpeg": "mp3",
        "audio/ogg": "ogg",
        "audio/x-realaudio": "ra",
        "video/3gpp": "3gp",
        "video/mpeg": "mpeg",
        "video/quicktime": "mov",
        "video/x-flv": "flv",
        "video/x-mng": "mng",
        "video/x-ms-asf": "asf",
        "video/x-ms-wmv": "wmv",
        "video/x-msvideo": "avi",
        "video/mp4": "mp4",
    };
    return mimes.hasOwnProperty(mime_type) ? "." + mimes[mime_type] : "";
}


function createKoDatatableSet(vm_fn, set) {
    var mapping = null;
    var curr_scope = this;
    curr_scope.onChangeFn = null;

    curr_scope.bindRedrawChngProps = function (instance) {
        $.each(instance.__OBSERVED_PROPS, function (i, prop) {
            instance[prop].subscribe(function (value) {
                if (not_empty(curr_scope.onChangeFn)) {
                    curr_scope.onChangeFn(instance, prop, value);
                }
            });
        });
    };


    curr_scope.getDataTable = function (element, options) {
        var table = null;
        var table_ws = $(element).closest('table');
        if ($.fn.dataTable.isDataTable(table_ws)) {
            table = table_ws.DataTable();
        }
        else {
            table = table_ws.DataTable(options);
        }
        return table;
    };

    curr_scope.map_cols = null;
    curr_scope.setMapCols = function (tbl_ws) {
        curr_scope.map_cols = {};
        var ws = tbl_ws.find("tr > td[data-bind*='text:'],tr > td *[data-bind*='text:']");

        ws.each(function () {
            var elem = $(this);
            var regexp = /text\s*:\s*([^,]+)/g;
            var attr = elem.attr('data-bind');
            var match = regexp.exec(attr);
            if (match) {
                var ko_attr = match[1];
                if (!curr_scope.map_cols.hasOwnProperty(ko_attr)) {
                    if (elem.is('td')) {
                        curr_scope.map_cols[ko_attr] = elem.index();
                    }
                    else {
                        curr_scope.map_cols[ko_attr] = elem.closest('td').index();
                    }

                }
            }
            //console.log(elem.prop('outerHTML'));
        });

    };

    curr_scope.createElement = function (params) {
        var element = new vm_fn(params);
        curr_scope.bindRedrawChngProps(element);
        return element;
    };

    curr_scope.getColumnIndex = function (prop) {

        return curr_scope.map_cols.hasOwnProperty(prop) ? curr_scope.map_cols[prop] : -1;
    };

    ko.bindingHandlers.dataTablesForEach = {
        page: 0,
        init: function (element, valueAccessor, allBindingsAccessor, viewModel, bindingContext) {
            var options = ko.unwrap(valueAccessor());
            ko.unwrap(options.data);
            curr_scope.setMapCols($(element).closest('table'));
            if (options.dataTableOptions.paging) {

                if (is_empty(curr_scope.onChangeFn)) {
                    curr_scope.onChangeFn = function (instance, prop, value) {

                        var table = null;
                        var table_ws = $(element).closest('table');
                        table = table_ws.DataTable();
                        iprop = curr_scope.getColumnIndex(prop);
                        var rowIdx = -1;
                        var uid = instance[instance.__FIELD_UID];
                        var icol_uid = curr_scope.getColumnIndex(instance.__FIELD_UID);
                        table.rows({ order: 'current' }).every(function (index, element) {

                            var data = this.data();
                            if (data[icol_uid] == uid) {
                                rowIdx = index;
                            }
                        });

                        table.cell({ row: rowIdx, column: iprop }).data(value).draw(false);

                        //ko.bindingHandlers.dataTablesForEach.page = table.page();

                    }
                }

                valueAccessor().data.subscribe(function (changes) {
                    var table = $(element).closest('table').DataTable();
                    ko.bindingHandlers.dataTablesForEach.page = table.page();
                    table.destroy();
                }, null, 'arrayChange');
            }

            var nodes = Array.prototype.slice.call(element.childNodes, 0);
            ko.utils.arrayForEach(nodes, function (node) {
                if (node && node.nodeType !== 1) {
                    node.parentNode.removeChild(node);
                }
            });

            return ko.bindingHandlers.foreach.init(element, valueAccessor, allBindingsAccessor, viewModel, bindingContext);
        },
        update: function (element, valueAccessor, allBindings, viewModel, bindingContext) {
            var options = ko.unwrap(valueAccessor()),
                key = 'DataTablesForEach_Initialized';
            ko.unwrap(options.data);
            var table;
            if (!options.dataTableOptions.paging) {
                table = $(element).closest('table').DataTable();
                table.destroy();

            }

            ko.bindingHandlers.foreach.update(element, valueAccessor, allBindings, viewModel, bindingContext);

            table = $(element).closest('table').DataTable(options.dataTableOptions);

            //table = curr_scope.getDataTable(element, options.dataTableOptions);

            if (options.dataTableOptions.paging) {
                if (table.page.info().pages - ko.bindingHandlers.dataTablesForEach.page == 0)
                    table.page(--ko.bindingHandlers.dataTablesForEach.page).draw(false);
                else
                    table.page(ko.bindingHandlers.dataTablesForEach.page).draw(false);
            }
            if (!ko.utils.domData.get(element, key) && (options.data || options.length))
                ko.utils.domData.set(element, key, true);

            return { controlsDescendantBindings: true };
        }
    };

    mapping = ko.mapping.fromJS([]);

    // Convert the data set into observable objects, and will also add the
    // initial data to the table
    ko.mapping.fromJS(
        set,
        {
            key: function (data) {
                return ko.utils.unwrapObservable(data[data.__FIELD_UID]);
            },
            create: function (options) {
                var element = curr_scope.createElement(options.data);
                return element;
            }
        },
        mapping);

    mapping.addElement = function (params) {
        mapping.push(curr_scope.createElement(params));
    }

    mapping.updateElement = function (ref, params) {
        ref.assign(params);
    }

    return mapping;

}

function ShowDismissMessage(form, type, message) {
    $('#' + form).prepend('<div class="alert alert-' + type + ' alert-dismissible" role="alert" data-auto-dismiss="2000"><strong></strong>' + message + '</div>');
    $('.alert[data-auto-dismiss]').each(function (index, element) {
        var $element = $(element),
            timeout = $element.data('auto-dismiss') || 5000;
        setTimeout(function () {
            $element.fadeTo(500, 0).slideUp(500, function () {
                $(this).remove();
            });
        }, timeout);
    });
}


/*----------------------[bgin validar rut]-------------------------------------*/

function validarId(campoId, tipoId, pais = 'C') {
    var rut = campoId;
    var tmpstr = "";
    var i;
    for (i = 0; i < rut.length; i++)
        if (rut.charAt(i) != ' ' && rut.charAt(i) != '.' && rut.charAt(i) != '-') {
            tmpstr = tmpstr + rut.charAt(i);
        }
        else {
            return 1; /*formato incorrecto*/
        }

    rut = tmpstr;
    largo = rut.length;
    // [VARM+]
    tmpstr = "";
    for (i = 0; rut.charAt(i) == '0'; i++);
    for (; i < rut.length; i++)
        tmpstr = tmpstr + rut.charAt(i);
    rut = tmpstr;
    largo = rut.length;
    // [VARM-]
    if (largo < 2) {
        return 2; /*tamaño muy corto*/
    }
    for (i = 0; i < largo; i++) {
        if ((rut.charAt(i) != '0') && (rut.charAt(i) != '1') && (rut.charAt(i) != '2') && (rut.charAt(i) != '3') && (rut.charAt(i) != '4') && (rut.charAt(i) != '5') && (rut.charAt(i) != '6') && (rut.charAt(i) != '7') && (rut.charAt(i) != '8') && (rut.charAt(i) != '9') && (rut.charAt(i) != 'k') && (rut.charAt(i) != 'K')) {
            return 1; /*formato incorrecto*/
        }
    }

    //Valida rango de valores posibles
    rutMax = rut;
    tmpstr = "";
    for (i = 0; i < rutMax.length; i++)
        if (rutMax.charAt(i) != ' ' && rutMax.charAt(i) != '.' && rutMax.charAt(i) != '-')
            tmpstr = tmpstr + rutMax.charAt(i);
    tmpstr = tmpstr.substring(0, tmpstr.length - 1);
    if (tipoId != 'N') {
    }

    var invertido = "";
    for (i = (largo - 1), j = 0; i >= 0; i--, j++)
        invertido = invertido + rut.charAt(i);
    var drut = "";
    drut = drut + invertido.charAt(0);
    drut = drut + '-';
    cnt = 0;
    for (i = 1, j = 2; i < largo; i++, j++) {
        if (cnt == 3) {
            drut = drut + '.';
            j++;
            drut = drut + invertido.charAt(i);
            cnt = 1;
        }
        else {
            drut = drut + invertido.charAt(i);
            cnt++;
        }
    }
    invertido = "";
    for (i = (drut.length - 1), j = 0; i >= 0; i--, j++) {
        if (drut.charAt(i) == 'k')
            invertido = invertido + 'K';
        else
            invertido = invertido + drut.charAt(i);
    }
    if (!checkDVPersona(rut, campoId, pais)) {
        return 3; /* Digito validacion erroneo*/
    }
    return 0; /* ok */
}


function checkDVPersona(crut, campoId, pais) {
    var rut = "";
    largo = crut.length;
    if (largo < 2) {
        return false;
    }
    if (largo > 2) {
        rut = crut.substring(0, largo - 1);
    }
    else {
        rut = crut.charAt(0);
    }
    dv = crut.charAt(largo - 1);

    if (rut == null || dv == null) {
        return false;
    }

    var dvr = '0';
    suma = 0;
    mul = 2;
    for (i = rut.length - 1; i >= 0; i--) {
        suma = suma + rut.charAt(i) * mul;
        if (mul == 7) {
            mul = 2;
        }
        else {
            mul++;
        }
    }
    res = suma % 11;
    if (res == 1) {
        dvr = 'k';
    }
    else {
        if (res == 0) {
            dvr = '0';
        }
        else {
            dvi = 11 - res;
            dvr = dvi + "";
        }
    }
    if (dvr != dv.toLowerCase()) {
        if (pais != 'C') {
            return true;
        } else {
            return false;
        }
    }
    return true;
}

function validarPatente(patente) {
    var numero = true;
    if (patente.length == 6) {
        if (isNaN(patente.charAt(0)) == false)
            numero = false;
        if (isNaN(patente.charAt(1)) == false)
            numero = false;
        if (isNaN(patente.charAt(2)) == true)
            numero = true;
        if (isNaN(patente.charAt(3)) == true)
            numero = true;
        if (isNaN(patente.charAt(4)) == true)
            numero = true;
        if (isNaN(patente.charAt(5)) == true)
            numero = true;
    }
    return numero;
}
function validaRutChileno(rutLote) {
    let rutLetra = rutLote;
    var subsFuncionario = rutLetra.substr(0, rutLetra.length - 1);
    var RutDigitoVerificador = rutLetra.substr(rutLetra.length - 1, 1);
    var M = 0, S = 1;
    for (; subsFuncionario; subsFuncionario = Math.floor(subsFuncionario / 10))
        S = (S + subsFuncionario % 10 * (9 - M++ % 6)) % 11;
    if (S == 0) S = 'K'; else S = S - 1;
    if (rutLetra.charAt(0) == '0' || RutDigitoVerificador != S) {
        return false;
    }
    else {
        return true;
    }
}

/*----------------------[end  validar rut]-------------------------------------*/
/*
$(document).ready(function () {
    $(document).on('click', '.download-ctl', function (e) {
        e.preventDefault();
        const url_dl = $(this).attr('href');
        $.ajax({
            url: url_dl,
            cache: false,
            xhrFields: {
                responseType: 'blob'
            }
        }).done(function (blob, status, xhr) {
            var filename = null;
            var disposition = xhr.getResponseHeader('Content-Disposition');
            if (disposition && disposition.indexOf('attachment') !== -1) {
                var fname_regex = /filename[^;=\n]*=((['"]).*?\2|[^;\n]*)/;
                var matches = fname_regex.exec(disposition);
                if (matches != null && matches[1]) {
                    filename = matches[1].replace(/['"]/g, '');
                }
            }
            filename = is_empty(filename) ? 'downloaded_file' + get_ext_from_mime(blob.type) : filename;
            if (blob.size > 0) {
                if (window.navigator.msSaveOrOpenBlob) {
                    window.navigator.msSaveBlob(blob, filename);
                }
                else {
                    var URL = URL = window.URL || window.webkitURL;
                    const url = URL.createObjectURL(blob);
                    const a = document.createElement('a');
                    a.style.display = 'none';
                    a.href = url;
                    a.download = filename;
                    document.body.appendChild(a);
                    a.click();
                    URL.revokeObjectURL(url);
                }
            }
            else {
                console.log("contenido vacio");
            }
        })
        .fail(function () { console.log("faileddddd"); });

       
    });
});
*/