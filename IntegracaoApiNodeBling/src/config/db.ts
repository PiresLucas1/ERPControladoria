import sql from 'mssql';

const connectionString ='Server=dbtotvs\\dbtotvs; Database = Zanup;User Id = rm; Password = rm; Encrypt = True; TrustServerCertificate = True';

let pool: sql.ConnectionPool | null = null;

export async function getConnection() {
    if (!pool) {
        try {
            pool = await sql.connect(connectionString!);
            console.log('Connected to the database');
        } catch (error) {
            console.error("❌ Erro ao conectar no banco:", error);
            throw error;
        }
    }
    return pool;
}
