#\!/bin/bash
# Script para respaldar la base de datos MySQL que corre en Docker
# Uso: bash backup.sh
MYSQL_CONTAINER="mysql_server"
DB_NAME="ControlAsistencia"
DB_ROOT_PASS="cedilloSQL"
LOCAL_BACKUP_DIR="./backups"

TIMESTAMP=$(date +"%Y%m%d_%H%M%S")
BACKUP_FILE="${LOCAL_BACKUP_DIR}/${DB_NAME}_backup_${TIMESTAMP}.sql"

echo "=== Respaldo de Base de Datos ==="
echo "Fecha: $(date '+%Y-%m-%d %H:%M:%S')"
echo ""

mkdir -p "${LOCAL_BACKUP_DIR}"

echo "[1/1] Creando respaldo desde el contenedor '$MYSQL_CONTAINER'..."
docker exec "$MYSQL_CONTAINER" mysqldump -u root -p"$DB_ROOT_PASS" "$DB_NAME" > "$BACKUP_FILE"

if [ $? -EQ 0 ]; then
  echo "Respaldp creado correctamente: ${BACKUP_FILE}"
  else
  echo "Error al crear el respaldo"
fi

echo "Proceso de respaldo finalizado"
echo "Archivo de respaldo: ${BACKUP_FILE}"