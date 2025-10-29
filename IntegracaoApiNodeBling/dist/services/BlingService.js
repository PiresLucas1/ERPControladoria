"use strict";
var __importDefault = (this && this.__importDefault) || function (mod) {
    return (mod && mod.__esModule) ? mod : { "default": mod };
};
Object.defineProperty(exports, "__esModule", { value: true });
exports.blingApiService = exports.axioRouterNotaFiscal = void 0;
const axios_1 = __importDefault(require("axios"));
const express_1 = require("express");
exports.axioRouterNotaFiscal = (0, express_1.Router)();
exports.blingApiService = axios_1.default.create({
    baseURL: 'https://api.bling.com.br/Api/v3'
});
//# sourceMappingURL=BlingService.js.map