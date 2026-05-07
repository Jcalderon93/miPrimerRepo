---
name: "🛠️ Mejora de Entorno de Desarrollo"
about: "Documentación de ajustes en la terminal y conexión WSL-VS Code."
title: "[CONFIG] - Optimización de visualización y conexión WSL"
labels: documentation, enhancement
assignees: Jcalderon93
---

## 📝 Descripción
Se realizaron ajustes técnicos en el entorno de desarrollo local (WSL2 - Ubuntu) para mejorar la legibilidad de la terminal y asegurar la sincronización correcta con GitHub a través de VS Code.

### ✅ Ajustes Realizados
1. **Limpieza de Interfaz:** Se eliminó el resaltado verde molesto en las carpetas montadas de la unidad `E:` configurando la variable `LS_COLORS` en el `.zshrc`.
2. **Personalización del Prompt:** Se configuró un prompt minimalista (Usuario en verde, Ruta en azul) para mantener el orden visual.
3. **Conexión WSL-VS Code:** Instalación de la extensión "WSL" para que VS Code reconozca el motor de Git de Linux y no el de Windows.
4. **Seguridad SSH:** Configuración del agente SSH para evitar bloqueos durante la sincronización de cambios.

### 🚀 Pasos para replicar el éxito
1. Configurar `PROMPT='%F{green}%n@%m%f:%F{blue}%1~%f $ '` en `~/.zshrc`.
2. Ejecutar `eval "$(ssh-agent -s)"` y `ssh-add` al iniciar sesión para la llave SSH.
3. Abrir proyectos desde WSL con el comando `code .`.

### 📌 Notas Adicionales
- La unidad de 4TB (`/mnt/e/`) ahora funciona como el repositorio central de estudios.
- Se recomienda el uso de archivos `.md` para futuras documentaciones profesionales.