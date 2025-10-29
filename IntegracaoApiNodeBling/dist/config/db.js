"use strict";
var __importDefault = (this && this.__importDefault) || function (mod) {
    return (mod && mod.__esModule) ? mod : { "default": mod };
};
Object.defineProperty(exports, "__esModule", { value: true });
exports.getConnection = getConnection;
const mssql_1 = __importDefault(require("mssql"));
const connectionString = process.env.DB_CONNECTION_STRING;
let pool = null;
async function getConnection() {
    if (!pool) {
        try {
            pool = await mssql_1.default.connect(connectionString);
            console.log('Connected to the database');
        }
        catch (error) {
            console.error("❌ Erro ao conectar no banco:", error);
            throw error;
        }
    }
    return pool;
}
//# sourceMappingURL=db.js.map