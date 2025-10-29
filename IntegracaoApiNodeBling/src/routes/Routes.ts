import { Router } from 'express';
import { blingApiService } from '../services/BlingService';
import { getToken } from '../services/TokenService';

export const routerNotaFiscal = Router();


routerNotaFiscal.get("/nfe/:numeroNfe", async (req, res) => {
    const { numeroNfe } = req.params; 

    const token = await getToken();
    try {

        const response = await blingApiService.get(`/nfe/${numeroNfe}`, {
            headers: {
                'Authorization': `Bearer ${token}`
            },
            
        });

        // Retorna o JSON que veio do Bling para o cliente
        res.json(response.data);
        } catch (error: any) {
            console.error('Erro ao buscar NFe no Bling:', error.message);
            res.status(error.response?.status || 500).json({ error: error.message });
        }
});
