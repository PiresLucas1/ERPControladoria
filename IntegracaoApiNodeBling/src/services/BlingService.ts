import axios from 'axios';
import https from 'https';
import { Router } from 'express';

export const axioRouterNotaFiscal = Router();
export const blingApiService = axios.create({
    baseURL: 'https://api.bling.com.br/Api/v3',
    httpsAgent: new https.Agent({
        rejectUnauthorized: false,     
    })
})


