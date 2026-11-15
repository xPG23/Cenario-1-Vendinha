CREATE TABLE clientes (
    cpf VARCHAR(14) PRIMARY KEY,
    nome VARCHAR(150) NOT NULL,
    email VARCHAR(150),
    datanascimento DATE NOT null,
    data_inscricao TIMESTAMP WITH TIME ZONE NOT NULL DEFAULT CURRENT_TIMESTAMP
);


CREATE TABLE dividas (
    id SERIAL PRIMARY KEY,
    valor NUMERIC(18,2) NOT NULL,
    status BOOLEAN NOT NULL DEFAULT FALSE,
    data_criacao TIMESTAMP WITH TIME ZONE NOT NULL,
    data_pagamento TIMESTAMP WITH TIME ZONE NULL,
    cliente_cpf VARCHAR(14) NOT NULL,

    CONSTRAINT fk_divida_cliente
        FOREIGN KEY (cliente_cpf)
        REFERENCES clientes(cpf)
);


drop table clientes cascade;
drop table dividas cascade;



