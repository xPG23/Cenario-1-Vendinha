select * from clientes c  

select * from dividas d


INSERT INTO clientes (cpf, nome, email, datanascimento) VALUES
('104.332.181-00', 'João Pedro Silva', 'joao.silva@email.com', '1995-04-12'),
('960.013.389-14', 'Maria Oliveira Santos', 'maria.santos@email.com', '1988-09-23'),
('083.863.794-99', 'Carlos Eduardo Souza', 'carlos.souza@email.com', '1992-01-15'),
('026.542.351-14', 'Ana Beatriz Costa', 'ana.costa@email.com', '2000-06-30'),
('161.559.407-89', 'Lucas Ferreira Lima', 'lucas.lima@email.com', '1997-11-08'),
('816.184.959-50', 'Juliana Martins Rocha', 'juliana.rocha@email.com', '1990-03-19'),
('310.341.316-56', 'Rafael Almeida', 'rafael.almeida@email.com', '1985-07-25'),
('475.255.341-44', 'Camila Rodrigues', 'camila.rodrigues@email.com', '1999-12-02'),
('928.327.648-51', 'Gabriel Pereira', 'gabriel.pereira@email.com', '1994-05-17'),
('350.305.641-60', 'Fernanda Carvalho', 'fernanda.carvalho@email.com', '1987-08-11'),
('395.376.724-09', 'Matheus Gomes', 'matheus.gomes@email.com', '2001-02-14'),
('238.849.696-92', 'Beatriz Ribeiro', 'beatriz.ribeiro@email.com', '1996-10-21'),
('532.871.012-69', 'Thiago Mendes', 'thiago.mendes@email.com', '1993-04-05'),
('269.166.978-57', 'Larissa Barbosa', 'larissa.barbosa@email.com', '1998-07-16'),
('480.184.514-27', 'Felipe Nascimento', 'felipe.nascimento@email.com', '1989-11-29'),
('627.048.281-05', 'Amanda Cardoso', 'amanda.cardoso@email.com', '1991-01-09'),
('489.325.288-70', 'Bruno Teixeira', 'bruno.teixeira@email.com', '1995-09-13'),
('095.701.543-73', 'Isabela Moreira', 'isabela.moreira@email.com', '2002-03-27'),
('039.117.182-84', 'Diego Araujo', 'diego.araujo@email.com', '1986-06-18'),
('278.248.963-15', 'Mariana Lopes', 'mariana.lopes@email.com', '1997-12-07'),
('834.657.871-70', 'André Luiz Freitas', 'andre.freitas@email.com', '1990-02-22'),
('331.509.839-59', 'Patricia Monteiro', 'patricia.monteiro@email.com', '1984-05-14'),
('301.031.051-07', 'Rodrigo Vieira', 'rodrigo.vieira@email.com', '1993-08-31'),
('834.738.299-94', 'Carolina Dias', 'carolina.dias@email.com', '2000-10-10'),
('737.631.165-32', 'Vinicius Correia', 'vinicius.correia@email.com', '1996-01-26'),
('667.010.651-39', 'Leticia Castro', 'leticia.castro@email.com', '1992-04-03'),
('333.872.624-42', 'Gustavo Pinto', 'gustavo.pinto@email.com', '1988-12-19'),
('731.781.080-09', 'Bianca Ramos', 'bianca.ramos@email.com', '1999-06-08'),
('132.677.360-72', 'Leonardo Campos', 'leonardo.campos@email.com', '1987-03-11'),
('260.647.468-66', 'Sofia Fernandes', 'sofia.fernandes@email.com', '2001-09-05');


INSERT INTO dividas (valor, status, data_criacao, data_pagamento, cliente_cpf) VALUES
(450.00, TRUE,  '2026-01-10 10:30:00-03', '2026-01-20 14:00:00-03', '104.332.181-00'),
(1250.50, FALSE, '2026-02-05 09:15:00-03', NULL, '960.013.389-14'),
(89.90, TRUE,  '2026-01-15 11:00:00-03', '2026-01-18 16:30:00-03', '083.863.794-99'),
(2300.00, FALSE, '2026-03-01 08:45:00-03', NULL, '026.542.351-14'),
(750.75, TRUE,  '2026-02-10 13:20:00-03', '2026-02-25 10:00:00-03', '161.559.407-89'),
(320.00, FALSE, '2026-02-18 15:30:00-03', NULL, '816.184.959-50'),
(1890.00, TRUE,  '2026-01-22 09:00:00-03', '2026-02-02 12:00:00-03', '310.341.316-56'),
(150.00, FALSE, '2026-03-05 14:10:00-03', NULL, '475.255.341-44'),
(4200.00, FALSE, '2026-02-12 10:45:00-03', NULL, '928.327.648-51'),
(560.90, TRUE,  '2026-01-30 16:00:00-03', '2026-02-10 11:30:00-03', '350.305.641-60'),

(980.00, FALSE, '2026-02-20 08:30:00-03', NULL, '395.376.724-09'),
(275.50, TRUE,  '2026-01-12 12:15:00-03', '2026-01-19 09:00:00-03', '238.849.696-92'),
(3100.00, FALSE, '2026-03-08 10:00:00-03', NULL, '532.871.012-69'),
(120.00, TRUE,  '2026-02-01 14:30:00-03', '2026-02-05 15:00:00-03', '269.166.978-57'),
(650.00, FALSE, '2026-02-25 09:45:00-03', NULL, '480.184.514-27'),
(1750.00, TRUE,  '2026-01-18 11:20:00-03', '2026-02-01 10:00:00-03', '627.048.281-05'),
(95.50, FALSE, '2026-03-10 13:00:00-03', NULL, '489.325.288-70'),
(2450.00, TRUE,  '2026-01-25 08:00:00-03', '2026-02-15 16:00:00-03', '095.701.543-73'),
(530.00, FALSE, '2026-02-28 16:45:00-03', NULL, '039.117.182-84'),
(890.90, TRUE,  '2026-02-03 10:30:00-03', '2026-02-12 14:00:00-03', '278.248.963-15'),

(5000.00, FALSE, '2026-03-02 09:00:00-03', NULL, '834.657.871-70'),
(210.00, TRUE,  '2026-01-08 15:00:00-03', '2026-01-15 11:00:00-03', '331.509.839-59'),
(1350.00, FALSE, '2026-03-04 12:30:00-03', NULL, '301.031.051-07'),
(420.80, TRUE,  '2026-02-07 09:20:00-03', '2026-02-14 13:30:00-03', '834.738.299-94'),
(780.00, FALSE, '2026-03-06 14:00:00-03', NULL, '737.631.165-32'),
(1600.00, TRUE,  '2026-01-28 10:10:00-03', '2026-02-08 15:45:00-03', '667.010.651-39'),
(65.90, FALSE, '2026-03-09 08:15:00-03', NULL, '333.872.624-42'),
(2950.00, TRUE,  '2026-02-15 11:30:00-03', '2026-03-01 09:30:00-03', '731.781.080-09'),
(340.00, FALSE, '2026-03-11 16:00:00-03', NULL, '132.677.360-72'),
(1100.00, TRUE,  '2026-02-22 13:45:00-03', '2026-03-05 10:15:00-03', '260.647.468-66');


