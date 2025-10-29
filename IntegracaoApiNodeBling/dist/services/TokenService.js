"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.getToken = getToken;
const db_1 = require("../config/db");
let currentToken = null;
async function getToken() {
    const now = Date.now();
    console.log("Buscando token");
    const conn = await (0, db_1.getConnection)();
    const result = await conn.request().query('select token.Token from tblAutenticacaoBling token where token.Ativo = 1');
    currentToken = result.recordset[0].Token;
    //lastUpdated = result
    return currentToken;
}
//# sourceMappingURL=TokenService.js.map