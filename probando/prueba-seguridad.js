const express = require('express');
const app = express();

app.get('/buscar', (req, res) => {
    const idUsuario = req.query.id;
    
    // ESTO ES UNA INYECCIÓN SQL DIRECTA. 
    // CodeQL detectará que 'idUsuario' entra desde la web sin filtrar y va directo a la base de datos.
    const consulta = "SELECT * FROM usuarios WHERE id = '" + idUsuario + "'";
    
    db.query(consulta, (err, result) => {
        res.send(result);
    });
});