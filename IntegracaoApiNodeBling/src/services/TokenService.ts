import { getConnection } from '../config/db'

let currentToken: string | null = null;

export async function getToken() {
    const now = Date.now();
    
    console.log("Buscando token");

    const conn = await getConnection();
    const result = await conn.request().query('select token.Token from tblAutenticacaoBling token where token.Ativo = 1');

    currentToken = result.recordset[0].Token;
    //lastUpdated = result

    return currentToken;

}