import express from "express";
import { routerNotaFiscal } from "./routes/Routes";
const app = express();

app.use(express.json());
app.use(routerNotaFiscal);



app.listen(3000, () => {
    console.log("Server is running on port 3000")
});