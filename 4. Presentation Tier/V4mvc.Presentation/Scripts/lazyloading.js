var myApp = (function (myApp) {

    myApp.LazyLoadingViewModel = function (url,tab=0,model=null) {
        var self = this;
        self.callDiferida = ko.observable(true);
        self.start = ko.observable(0);
        self.count = ko.observable(0);
        self.sort = ko.observable('0');
        self.length = ko.observable(10);
        self.registros = ko.observable();
        self.pagination = ko.observable(0);
        self.ordering = ko.observable('asc');
        self.arrayList = ko.observableArray();
        self.listLength = ko.observableArray([10, 25, 50, 100]);
        self.classOrder = ko.observable('pull-right fa fa-sort-alpha-asc');
        self.tab = ko.observable(tab);

        self.col0 = ko.observable().extend({ throttle: 1000 }); self.col0.subscribe(function () { self.reset() });
        self.col1 = ko.observable().extend({ throttle: 1000 }); self.col1.subscribe(function () { self.reset() });
        self.col2 = ko.observable().extend({ throttle: 1000 }); self.col2.subscribe(function () { self.reset() });
        self.col3 = ko.observable().extend({ throttle: 1000 }); self.col3.subscribe(function () { self.reset() });
        self.col4 = ko.observable().extend({ throttle: 1000 }); self.col4.subscribe(function () { self.reset() });
        self.col5 = ko.observable().extend({ throttle: 1000 }); self.col5.subscribe(function () { self.reset() });
        self.col6 = ko.observable().extend({ throttle: 1000 }); self.col6.subscribe(function () { self.reset() });
        self.col7 = ko.observable().extend({ throttle: 1000 }); self.col7.subscribe(function () { self.reset() });
        self.col8 = ko.observable().extend({ throttle: 1000 }); self.col8.subscribe(function () { self.reset() });
        self.col9 = ko.observable().extend({ throttle: 1000 }); self.col9.subscribe(function () { self.reset() });
        self.col10 = ko.observable().extend({ throttle: 1000 }); self.col10.subscribe(function () { self.reset() });
        self.col11 = ko.observable().extend({ throttle: 1000 }); self.col11.subscribe(function () { self.reset() });
        self.col12 = ko.observable().extend({ throttle: 1000 }); self.col12.subscribe(function () { self.reset() });
        self.col13 = ko.observable().extend({ throttle: 1000 }); self.col13.subscribe(function () { self.reset() });


        if (model != null) {
            self.bindingData = function (data) { for (var key in data) { self.arrayList.push(new model(ko.toJS(data[key]))); } };
        }
        else { self.bindingData = function (data) { for (var key in data) { self.arrayList.push(ko.toJS(data[key])); } }; }

        self.counter = function (value) {
            self.registros(value * self.length());
            self.start((value * self.length()) - self.length());
        };

        self.reset = function () {
            self.start(0);
            self.counter(1);
            self.pagination(0);
            self.loadDiferida();
        };

        self.order = function (value) {
            self.sort(value);
            self.pagination(0);
            self.start(0);
            self.ordering() == 'asc' ? self.ordering('desc') : self.ordering('asc');
            self.classOrder('pull-right fa fa-sort-alpha-' + self.ordering());
        };

        self.length.subscribe(function () { self.reset() });
        self.start.subscribe(function () { self.loadDiferida() });
        self.ordering.subscribe(function () { self.loadDiferida() });

        self.loadDiferida = function () {
            if (self.callDiferida()) {
                var data = {
                    START: self.start,
                    LENGTH: self.length,
                    COL0: self.col0,
                    COL1: self.col1,
                    COL2: self.col2,
                    COL3: self.col3,
                    COL4: self.col4,
                    COL5: self.col5,
                    COL6: self.col6,
                    COL7: self.col7,
                    COL8: self.col8,
                    COL9: self.col9,
                    COL10: self.col10,
                    COL11: self.col11,
                    COL12: self.col12,
                    COL13: self.col13,
                    COLUMN: self.sort,
                    DIRECTION: self.ordering,
                    TAB: self.tab
                };
                $.ajax({
                    type: "GET",
                    url: url,
                    dataType: 'json',
                    global: false,
                    data: data,
                    success: function (response) {
                        self.arrayList.removeAll();
                        self.bindingData(response.data);
                        self.count(response.data.length > 0 ? response.data[0].COUNT : 0);
                        if (self.pagination() < 1) {
                            $(self.tab() != 0 ? '#pagination-' + self.tab() : '#pagination').pagination({
                                total: response.data.length > 0 ? response.data[0].COUNT : 0,
                                current: 1,
                                length: self.length(),
                                size: 3,
                                prev: "Ant",
                                next: "Sig",
                                click: function (e) {
                                    self.pagination(e.current);
                                    self.counter(e.current);
                                }
                            });
                        }
                    }
                });
            }
        }

        self.clear = function () {
            self.start(0);
            self.length(10);
            self.pagination(0);
            self.ordering('asc');
            self.col0('');
            self.col1('');
            self.col2('');
            self.col3('');
            self.col4('');
            self.col5('');
            self.col6('');
            self.col7('');
            self.col8('');
            self.col9('');
            self.col10('');
            self.col11('');
            self.col12('');
            self.col13('');
        }
        self.loadDiferida();
        self.counter(1);
    }
    return myApp;
}(myApp || {}));