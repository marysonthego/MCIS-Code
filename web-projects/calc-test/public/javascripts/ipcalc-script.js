module.exports = {

    validate: function () {
    console.log('in validate');
    let text = document.getElementById('ipAddr').textContent;
    console.log('ipAddr = ' + text);
    document.getElementById('ipAddr').textContent = '255.255.255.255';
    console.log('ipAddr = ' + text);
    return true;
    }
};