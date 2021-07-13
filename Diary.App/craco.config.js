/* craco.config.js */
module.exports = {
    babel: {
        plugins: [['import', {
            libraryName: 'antd',
            libraryDirectory: 'es',
            style: 'css',
        }]],
    },
};