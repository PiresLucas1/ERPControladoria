"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.routerNotaFiscal = void 0;
const express_1 = require("express");
const BlingService_1 = require("../services/BlingService");
const TokenService_1 = require("../services/TokenService");
exports.routerNotaFiscal = (0, express_1.Router)();
exports.routerNotaFiscal.get("/nfe/:numeroNfe", async (req, res) => {
    const { numeroNfe } = req.params;
    const token = await (0, TokenService_1.getToken)();
    try {
        const response = await BlingService_1.blingApiService.get(`/nfe/${numeroNfe}`, {
            headers: {
                'Authorization': `Bearer ${token}`
            }
        });
        // Retorna o JSON que veio do Bling para o cliente
        res.json(response.data);
    }
    catch (error) {
        console.error('Erro ao buscar NFe no Bling:', error.message);
        res.status(error.response?.status || 500).json({ error: error.message });
    }
});
//# sourceMappingURL=Routes.js.map