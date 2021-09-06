function ActivePanel() {
    jsPanel.create({
        theme: 'warning',
        headerTitle: 'İlk Panel',
        position: 'center-top 0 58',
        contentSize: '450 250',
        content: '<p>öRNEK Panelimiz Başarıyla Oluştu</p>',
        callback: function () {
            this.content.style.padding = '20px';
        },
        onbeforeclose: function () {
            return confirm('Paneli Kapatmak İstediğinizden Emin Misiniz?');
        }
    });
}