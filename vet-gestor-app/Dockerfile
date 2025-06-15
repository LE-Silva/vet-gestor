# Stage 1: Build
FROM node:18-alpine AS build

WORKDIR /app

# Copia package.json e package-lock.json (ou yarn.lock)
COPY package*.json ./

# Instala dependências
RUN npm install

# Copia todo o código do app
COPY . .

# Build da aplicação Nuxt para produção
RUN npm run build

# Stage 2: Runtime (imagem menor)
FROM node:18-alpine AS runtime

WORKDIR /app

# Copia somente arquivos necessários do build
COPY --from=build /app/.output ./

# Expõe a porta padrão do Nuxt (3000)
EXPOSE 3000

# Comando para rodar o servidor Nuxt
CMD ["node", ".output/server/index.mjs"]