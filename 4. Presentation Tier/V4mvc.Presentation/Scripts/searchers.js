$("#searcher-workers").on("shown.bs.modal", function (e) {
    var modalId = $(e.relatedTarget).data('modal-id');
    if (modelWorkers != null) {
        modelWorkers.active(true);
        modelWorkers.init();
        modelWorkers.idModal(modalId);
        $('#searcher-workers').modal('show');
    }
    else {
        loadSearcherWorkers(modalId);
    }
});
$("#searcher-workers").on('hide.bs.modal', function () {
    modelWorkers.clear();
});

$("#searcher-transports").on("shown.bs.modal", function (e) {
    var modalId = $(e.relatedTarget).data('modal-id');
    if (modelTransport != null) {
        modelTransport.active(true);
        modelTransport.init();
        modelTransport.idModal(modalId);
        $('#searcher-transport').modal('show');
    }
    else {
        loadSearcherTransports(modalId);
    }
});
$("#searcher-transports").on('hide.bs.modal', function () {
    modelTransport.clear();
});

$("#searcher-enterprisectta").on("shown.bs.modal", function (e) {
    var modalId = $(e.relatedTarget).data('modal-id');
    if (modelEnterpriseCtta != null) {
        modelEnterpriseCtta.active(true);
        modelEnterpriseCtta.init();
        modelEnterpriseCtta.idModal(modalId);
        $('#searcher-enterprisectta').modal('show');
    }
    else {
        loadSearcherEnterpriseCtta(modalId);
    }
});
$("#searcher-enterprisectta").on('hide.bs.modal', function () {
    modelEnterpriseCtta.clear();
});

$("#searcher-enterprisemdte").on("shown.bs.modal", function (e) {
    var modalId = $(e.relatedTarget).data('modal-id');
    if (modelEnterpriseMdte != null) {
        modelEnterpriseMdte.active(true);
        modelEnterpriseMdte.init();
        modelEnterpriseMdte.idModal(modalId);
        $('#searcher-enterprisemdte').modal('show');
    }
    else {
        loadSearcherEnterpriseMdte(modalId);
    }
});
$("#searcher-enterprisemdte").on('hide.bs.modal', function () {
    modelEnterpriseMdte.clear();
});

$("#searcher-workersctta").on("shown.bs.modal", function (e) {
    var modalId = $(e.relatedTarget).data('modal-id');
    if (modelWorkersCtta != null) {
        modelWorkersCtta.active(true);
        modelWorkersCtta.init();
        modelWorkersCtta.idModal(modalId);
        $('#searcher-workersctta').modal('show');
    }
    else {
        loadSearcherWorkersCtta(modalId);
    }
});
$("#searcher-workersctta").on('hide.bs.modal', function () {
    modelWorkersCtta.clear();
});

$("#searcher-workersmdte").on("shown.bs.modal", function (e) {
    var modalId = $(e.relatedTarget).data('modal-id');
    if (modelWorkersMdte != null) {
        modelWorkersMdte.active(true);
        modelWorkersMdte.init();
        modelWorkersMdte.idModal(modalId);
        $('#searcher-workersmdte').modal('show');
    }
    else {
        loadSearcherWorkersMdte(modalId);
    }
});
$("#searcher-workersmdte").on('hide.bs.modal', function () {
    modelWorkersMdte.clear();
});

$("#searcherOstMadre").on("shown.bs.modal", function (e) {
    var modalId = $(e.relatedTarget).data('modal-id');
    if (modelWorkersOstMadre != null) {
        modelWorkersOstMadre.active(true);
        modelWorkersOstMadre.init();
        modelWorkersOstMadre.idModal(modalId);
        $('#searcherOstMadre').modal('show');
    }
    else {
        loadSearcherWorkersOstMadre(modalId);
    }
});
$("#searcherOstMadre").on('hide.bs.modal', function () {
    modelWorkersOstMadre.clear();
});

$("#searcherOstEmpresa").on("shown.bs.modal", function (e) {
    var modalId = $(e.relatedTarget).data('modal-id');
    if (modelWorkersOstEmpresa != null) {
        modelWorkersOstEmpresa.active(true);
        modelWorkersOstEmpresa.init();
        modelWorkersOstEmpresa.idModal(modalId);
        $('#searcherOstEmpresa').modal('show');
    }
    else {
        loadSearcherWorkersOstEmpresa(modalId);
    }
});
$("#searcherOstEmpresa").on('hide.bs.modal', function () {
    modelWorkersOstEmpresa.clear();
});

$("#searcher-cursos-mdte").on("shown.bs.modal", function (e) {
    var modalId = $(e.relatedTarget).data('modal-id');
    if (modelCursosMdte != null) {
        modelCursosMdte.active(true);
        modelCursosMdte.init();
        modelCursosMdte.idModal(modalId);
        $('#searcher-cursos-mdte').modal('show');
    }
    else {
        loadSearcherCursosMdte(modalId);
    }
});

$("#searcher-cursos-mdte").on('hide.bs.modal', function () {
    modelCursosMdte.clear();
});

$("#searcher-cursos-ctta").on("shown.bs.modal", function (e) {
    var modalId = $(e.relatedTarget).data('modal-id');
    if (modelCursosCtta != null) {
        modelCursosCtta.active(true);
        modelCursosCtta.init();
        modelCursosCtta.idModal(modalId);
        $('#searcher-cursos-ctta').modal('show');
    }
    else {
        LoadSearcherCursos(modalId);
    }
});

$("#searcher-cursos-ctta").on('hide.bs.modal', function () {
    modelCursosCtta.clear();
});

$("#searcher-salas-mdte").on("shown.bs.modal", function (e) {
    var modalId = $(e.relatedTarget).data('modal-id');
    if (modelSalasMdte != null) {
        modelSalasMdte.active(true);
        modelSalasMdte.init();
        modelSalasMdte.idModal(modalId);
        $('#searcher-salas-mdte').modal('show');
    }
    else {
        loadSearcherSalasMdte(modalId);
    }
});
$("#searcher-salas-mdte").on('hide.bs.modal', function () {
    modelSalasMdte.clear();
});



$("#searcher-cargos-ctta").on("shown.bs.modal", function (e) {
    var modalId = $(e.relatedTarget).data('modal-id');

    if (modelCargosCtta != null) {
        modelCargosCtta.callDiferida(true);
        modelCargosCtta.loadDiferida();
        $('#searcher-cargos-ctta').modal('show');
    }
    else {
        LoadSearcherCargos(modalId);
    }
});
$("#searcher-cargos-ctta").on('hide.bs.modal', function () {
    modelCargosCtta.clear();
});

$("#searcher-ost-ctta").on("shown.bs.modal", function (e) {
    var modalId = $(e.relatedTarget).data('modal-id');
    if (modelOSTCtta != null) {
        modelOSTCtta.callDiferida(true);
        modelOSTCtta.loadDiferida();
        $('#searcher-ost-ctta').modal('show');
    }
    else {
        LoadSearcherOST(modalId);
    }
});
$("#searcher-ost-ctta").on('hide.bs.modal', function () {
    modelOSTCtta.clear();
});

$("#searcher-workers-pases-ctta").on("shown.bs.modal", function (e) {
    var modalId = $(e.relatedTarget).data('modal-id');
    if (modelWorkersPasesCtta != null) {
        modelWorkersPasesCtta.idModal(modalId);
        modelWorkersPasesCtta.callDiferida(true);
        modelWorkersPasesCtta.loadDiferida();
        $('#searcher-workers-pases-ctta').modal('show');
    }
    else {
        LoadSearcherWorkersPases(modalId);
    }
});
$("#searcher-workers-pases-ctta").on('hide.bs.modal', function () {
    modelWorkersPasesCtta.clear();
});

$("#searcher-transports-pase").on("shown.bs.modal", function (e) {
    var modalId = $(e.relatedTarget).data('modal-id');
    if (modelTransports != null) {
        modelTransports.callDiferida(true);
        modelTransports.loadDiferida();
        /*modelTransport.active(true);
        modelTransport.init();
        modelTransport.idModal(modalId);*/
        $('#searcher-transport-pase').modal('show');
    }
    else {
        LoadSearcherTransports(modalId);
    }
});
$("#searcher-transports-pase").on('hide.bs.modal', function () {
    modelTransports.callDiferida(false);
    modelTransports.clear();
    //modelTransport.clear();
});

$("#searcher-workers-pases-visita-ctta").on("shown.bs.modal", function (e) {
    var modalId = $(e.relatedTarget).data('modal-id');
    if (modelWorkersPasesVisitaCtta != null) {
        modelWorkersPasesVisitaCtta.idModal(modalId);
        modelWorkersPasesVisitaCtta.callDiferida(true);
        modelWorkersPasesVisitaCtta.loadDiferida();
        $('#searcher-workers-pases-visita').modal('show');
    }
    else {
        LoadSearcherWorkersPasesVisita(modalId);
    }
});
$("#searcher-workers-pases-visita-ctta").on('hide.bs.modal', function () {
    modelWorkersPasesVisitaCtta.clear();
});

$("#searcher-workers-pases-autorizador-ctta").on("shown.bs.modal", function (e) {
    var modalId = $(e.relatedTarget).data('modal-id');
    if (modelWorkersPasesAutorizadorCtta != null) {
        modelWorkersPasesAutorizadorCtta.idModal(modalId);
        modelWorkersPasesAutorizadorCtta.callDiferida(true);
        modelWorkersPasesAutorizadorCtta.loadDiferida();
        $('#searcher-workers-pases-autorizador').modal('show');
    }
    else {
        LoadSearcherWorkersAutorizadorPases(modalId);
    }
});
$("#searcher-workers-pases-autorizador-ctta").on('hide.bs.modal', function () {
    modelWorkersPasesAutorizadorCtta.clear();
});


$("#searcher-centros-costo-ctta").on("shown.bs.modal", function (e) {
    var modalId = $(e.relatedTarget).data('modal-id');
    if (modelCentroCostosCtta != null) {
        modelCentroCostosCtta.callDiferida(true);
        modelCentroCostosCtta.loadDiferida();
        $('#searcher-centros-costo-ctta').modal('show');
    }
    else {
        LoadSearcherCentrosCostos(modalId);
    }
});
$("#searcher-centros-costo-ctta").on('hide.bs.modal', function () {
    modelCentroCostosCtta.clear();
});