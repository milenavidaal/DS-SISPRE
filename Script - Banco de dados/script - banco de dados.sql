# Sistema SISPRE

#ALUNO 01: Ana Beatriz Grego
#ALUNO 02: Maria Fernanda Moreira 
#ALUNO 03: Milena Evangelista Vidal
#ALUNO 04: Vitória Maria de Jesus Miranda
#ALUNO 05: Wallace Heleno Freire
#ALUNO 06: Willyam Fraga Tisher

create database sispre;
use sispre;


create table endereco(
id_end int primary key auto_increment,
complemento_end varchar (100),
numero_end int,
cep_end varchar(9),
bairro_end varchar (100),
cidade_end varchar (100),
uf_end varchar (2)
);


create table funcionario(
id_func int primary key auto_increment,
nome_func varchar (100),
telefone_func varchar (100),
email_func varchar (100),
cpf_func varchar(11),
funcao_func varchar (100),
fk_end int,
foreign key (fk_end) references endereco(id_end)
);


create table usuario(
id_usu int primary key auto_increment,
desc_usu varchar (100),
email_usu varchar(100),
senha_usu varchar(100),
fk_func int,
foreign key (fk_func) references funcionario(id_func)
);


create table cliente(
id_cli int primary key auto_increment,
nome_cli varchar (100),
telefone_cli varchar (100),
email_cli varchar (100),
cpf_cli varchar(11),
fk_end int,
foreign key (fk_end) references endereco(id_end)
);


create table entrar (
id_entrar int not null primary key auto_increment,
senha_entrar varchar (100) not null,
email_entrar varchar (200) not null,
id_usu_fk int,
foreign key (id_usu_fk) references usuario (id_usu)
);

create table produto (
id_prod int primary key auto_increment,
nome_prod varchar (100),
valor_prod double,
estoque_prod int
);


create table venda (
id_vend int primary key auto_increment,
data_vend date,
valor_vend double, 
fk_cli int,
fk_func int,
fk_prod int,
foreign key (fk_cli) references cliente(id_cli),
foreign key (fk_func) references funcionario (id_func)
);


create table produtos_venda (
id_prod_vend int primary key not null auto_increment,
quant_prod_vend int,
fk_prod int,
fk_vend int,
foreign key (fk_prod) references Produto (id_prod),
foreign key (fk_vend) references Venda (id_vend)
);



create table controle (
id_cont int not null primary key auto_increment,
mes_cont varchar (100) not null,
saldoanterior_cont double not null,
totalrenda_cont double not null,
totalgastos_cont double not null,
saldofinal_cont double not null );

insert into controle values (null, 'Agosto/2020', 0, 4000, 1000, 3000 );


create table caixa(
id_cx int primary key auto_increment,
saldoinicial_cx double,
totalrecebimento_cx double,
pagamentototal_cx double,
saldofinal_cx double
);


create table despesa(
id_desp int not null primary key auto_increment,
referencia_desp varchar(100),
data_desp date,
valor_desp double not null,
id_cont_fk int not null,
foreign key (id_cont_fk) references controle (id_cont)
);


create table pagamento (
id_pagamento int primary key not null auto_increment,
tipopagamento varchar(100),
datapagamento date,
vlrpagamento double,
id_vend_fk int,
foreign key (id_vend_fk) references venda (id_vend),
id_cx_fk int,
foreign key (id_cx_fk) references caixa (id_cx)
);


#PROCEDIMENTOS

#PROCEDIMENTO PRODUTOS
delimiter $$
create procedure InserirProduto (nome varchar(200), estoque int, valor float)
begin
if (valor > 0) then 
if (estoque > 0 and estoque < 1000) then
insert into Produto values (null, nome, estoque, valor);
select 'O produto foi inserido com Sucesso!' as confirmação;
    else
select 'O produto ', nome,' de ', valor, ' com o estoque de ', estoque, 'tem o estoque menor que ZERO ou maior que MIL, tente novamente!' as Alerta;
end if;
else
select 'O produto ', nome,' de ', valor, ' com o estoque de ', estoque, ' tem o preço abaixo de ZERO, tente novamente!' as Alerta;
end if;

end $$ delimiter ;

call InserirProduto ('Boneca Barbie', 10, 19.90);
call InserirProduto ('Boneca Angelina', 1000, 9.40);
call InserirProduto ('Brinquedinho de Bolhas', 1500, 0);
call InserirProduto ('Carrinho', 5, 4.50);
call InserirProduto ('Arminha de Brinquedo', 5, 61.00);
call InserirProduto ('Soco Inglês de Brinquedo', 5, 133.50);

select * from produto;




#PROCEDIMENTO DE VENDA
delimiter $$
create procedure inserirVenda (datav date, valorv double)
begin
insert into Venda ( data_vend, valor_vend) values ( datav, valorv );
select 'A venda foi realizada com Sucesso!' as Confirmação;
end

 $$ delimiter ;

call inserirVenda ('2019-10-13', 0);
call inserirVenda ('2021-12-11', 0);

select * from venda;



#PROCEDIMENTOS PRODUTO VENDA
delimiter $$
create trigger att_ProdutosVenda after insert
on produtos_venda for each row
begin

declare new_preco double;
set new_preco = (select valor_prod from produto where id_prod = new.fk_prod);

update venda 
set valor_vend = new.quant_prod_vend * new_preco
where id_vend = new.fk_vend;

update produto 
set estoque_prod = estoque_prod - new.quant_prod_vend
where id_prod= new.fk_prod;
end;

 $$ delimiter ;

insert into produtos_venda values (3, 1, 1, 1);

select * from produtos_venda;




#PROCEDIMENTOS USUARIO
delimiter $$
create procedure inserirUsuario (id_usu int, desc_usu varchar(100), email_usu varchar(200), senha_usu varchar(100))
begin
insert into usuario (id_usu, desc_usu, email_usu, senha_usu) values ( null, desc_usu, email_usu, senha_usu );
select 'O usuário foi cadastrado com Sucesso!' as Confirmação;
end

 $$ delimiter ;

call inserirUsuario (1, 'Funcionário de Vendas', 'let@gmail.com', '2232342');
call inserirUsuario (2, 'Funcionário de Vendas', 'maik@gmail.com', '1FD2345');

select * from usuario;



#PROCEDIMENTOS CLIENTE
delimiter $$
create procedure inserirCliente (id_cli int, nome_cli varchar (100), telefone_cli varchar (100), email_cli varchar (100), cpf_cli int)
begin
insert into cliente (id_cli, nome_cli, telefone_cli, email_cli, cpf_cli) values ( id_cli, nome_cli, telefone_cli, email_cli, cpf_cli);
select 'O cliente foi cadastrado com Sucesso!' as Confirmação;
end

 $$ delimiter ;

call inserirCliente (1, 'Kamila Santos', '(64)96857-0140', 'kamilas@gmail.com', 8745746);
call inserirCliente (2, 'Frederico Soares', '(64)98745-1047', 'freds@gmail.com', 5666541);

select * from cliente;




#PROCEDIMENTOS FUNCIONÁRIO
delimiter $$
create procedure inserirFuncionario (id_func int, nome_func varchar (100), telefone_func varchar (100), email_func varchar (100), cpf_func int, funcao_func varchar (100))
begin
insert into funcionario ( id_func, nome_func, telefone_func, email_func, cpf_func, funcao_func) values ( null, nome_func, telefone_func, email_func, cpf_func, funcao_func);
select 'O funcionário foi cadastrado com Sucesso!' as Confirmação;
end

 $$ delimiter ;

call inserirFuncionario (1, 'Maria Clara Souza', '(64)99987-2267', 'mariac@gmail.com', 96588, 'vendedor');
call inserirFuncionario (2, 'Márcio Oliveira', '(64)98574-4747', 'marcioolivs@gmail.com', 8745584, 'vendedor');

select * from funcionario;



#PROCEDIMENTO LOGIN
delimiter $$
create procedure inserirLogin (usuario int, email varchar(200), senha varchar(100))
begin

declare senhavalida varchar (100);
declare emailvalido varchar (200);

set emailvalido = (select email_usu from usuario where (email_usu = email));
set senhavalida = (select senha_usu from usuario where (senha_usu = senha));

if(emailvalido is null) then

select 'Endereço de email Incorreto! Por favor tente novamente!' as Alerta;
    
else
if(senhavalida is null) then
    
select 'Senha Incorreta! por favor tente novamente!' as Alerta;
        
else
    
insert into Entrar values (null, usuario, email_usu, senha_usu );
select 'Login cadastrado com Sucesso!' as Confirmação;

    end if;
end if;
end;

$$ delimiter ;

call inserirLogin (1, 'luan@gmail.com', '12348u');

select * from usuario;




#PROCEDIMENTO DE ENDEREÇO
delimiter $$
create procedure inserirEndereco (id_end int, complemento_end varchar (100), numero_end int, cep_end int, bairro_end varchar (100), cidade_end varchar (100), uf_end varchar (2))
begin
insert into endereco (id_end, complemento_end, numero_end, cep_end, bairro_end, cidade_end, uf_end) values (null, complemento_end, numero_end, cep_end, bairro_end, cidade_end, uf_end);
select 'O endereço foi cadastrado com Sucesso!' as Confirmação;
end

 $$ delimiter ;
 

call inserirEndereco (1, 'Av. 3 de Maio', 1450, 7845898, 'Limoeiro', 'São Paulo', 'SP');
call inserirEndereco (2, 'Av. Cortella', 2145, 874589, 'Cascalho', 'São Paulo', 'SP');

select * from endereco;



#PROCEDIMENTO CONTROLE
delimiter $$
create procedure inserirControle (mes varchar(100))
begin

declare saldo_final_ant double;
declare saldo_ant double;

set saldo_final_ant = (select saldofinal_cont from controle where (select max(id_cont) from controle));
set saldo_ant = (select saldoanterior_cont from controle where (select max(id_cont) from controle));

if ((select mes_cont from controle) = mes ) then 
    select concat('O mês inserido já existe, por favor, tente novamente!') as Alerta;
else
    insert into controle
    (mes_cont, totalrenda_cont, saldoanterior_cont,  saldofinal_cont, totalgastos_cont)
    values (mes, 0, 0, saldo_final_ant, saldo_ant);
    select  concat('O mês foi inserido com Sucesso!') as Confirmação;
end if;

end;

$$ delimiter ;

call inserirControle ('Setembro/2020');



#PROCEDIMENTO DESPESA
delimiter $$
create procedure inserirDespesa (referência varchar (100) , data_ date, valor double, id_cont_fk int)
begin

declare saldo_final double;

set saldo_final = (select saldofinal_cont from controle where (mes_cont = 'Setembro/2020'));

if (saldo_final >= valor ) then 
insert into despesa (id_desp, referencia_desp, data_desp, valor_desp, id_cont_fk)
values (null, referência, data_, valor,  2);
select concat('Despesa inserida com Sucesso! O saldo é POSITIVO no valor de ', saldo_final) as Confirmação;
else
if (saldo_final < valor ) then 
insert into despesa (id_desp, referencia_desp, data_desp, valor_desp, id_cont_fk)
values (null, referência, data_, valor,  2);
select concat('Despesa inserida com Sucesso! O saldo é NEGATIVO no valor de ', saldo_final) as Confirmação;
end if;
end if;

end;

$$ delimiter ;

call inserirDespesa ('Energia','2020-08-15', 840, 2);


select * from despesa;
select * from controle;

delimiter $$
create trigger inserirDespesa after insert on despesa for each row
begin

update controle 
set totalgastos_cont = new.valor_desp + totalgastos_cont where id_cont = new.id_cont_fk;

update controle 
set saldofinal_cont = (saldoanterior_cont + totalrenda_cont) - totalgastos_cont where id_cont = new.id_cont_fk;

end;

$$ delimiter ;

delimiter $$
create trigger attDespesa after update on despesa for each row
begin

update controle 
set totalgastos_cont = (totalgastos_cont - old.valor_desp) + new.valor_desp where id_cont = new.id_cont_fk;

update controle 
set saldofinal_cont = (saldoanterior_cont + totalrenda_cont) - totalgastos_cont where id_cont = new.id_cont_fk;

end;

$$ delimiter ;

delimiter $$
create trigger delete_despesa after delete on despesa for each row
begin

update controle 
set totalgastos_cont = totalgastos_cont - old.valor_desp where id_cont = old.id_cont_fk;

update controle 
set saldofinal_cont = (saldoanterior_cont + totalrenda_cont) - totalgastos_cont where id_cont = old.id_cont_fk;

end;

$$ delimiter ;

insert into despesa values (null, 'Pagamento Água', '2021-06-29', 150.00, 1);
insert into despesa values (null, 'Pagamento Energia', '2021-06-30', 150.00, 2);

delete from despesa where id_desp = 1;

update despesa set valor_desp = 280.00 where id_desp = 1;

select * from controle;
select * from despesa;



#PROCEDURE RECEBIMENTO

delimiter $$
create procedure inserirPagamento (id_pagamento int, tipopagamento varchar(100), datapagamento date, vlrpagamento double, id_vend_fk int)
begin

if (vlrpagamento < 0 ) then 
select concat('O pagamento possui valor abaixo de 0, tente novamente!') as Alerta;
else
    insert into pagamento (id_pagamento, tipopagamento, datapagamento, vlrpagamento, id_vend_fk)
values (null, tipopagamento, datapagamento, vlrpagamento, 1);
select concat('O pagamento foi inserida com Sucesso!') as Confirmação;
end if;

end;

$$ delimiter ;


call inserirPagamento (1, 'À vista', '2021-07-18', 150, 1);

select * from pagamento;
select * from controle;


#PROCEDIMENTO CAIXA
delimiter $$
create procedure inserirCaixa (saldoinicial_cx double)
begin

insert into caixa (saldoinicial_cx) values (saldoinicial_cx);
select 'Caixa inserido com Sucesso!' as Confirmação;

end;
$$ delimiter ;

call inserirCaixa (3000.00);

delimiter $$
create trigger attCaixareceb after insert
on pagamento for each row
begin
update caixa set totalrecebimento_cx = totalrecebimento_cx + new.vlrpagamento where id_cx = new.id_cx_fk;
update caixa set saldofinal_cx = saldoinicial_cx + totalrecebimento_cx - totalpagamento_cx where id_cx = new.id_cx_fk;
end $$ delimiter ;

delimiter $$
create trigger attCaixapag after insert
on pagamento for each row
begin
update caixa set totalpagamento_cx = total_pagamento_caixa + new.vlrpagamento where id_caixa = new.id_cx_fk;
update caixa set saldofinal_cx = saldoinicial_cx + totalrecebimento_cx- totalpagamento_cx where id_cx = new.id_cx_fk;
end $$ delimiter ;

call inserirCaixa(800.42);

select * from caixa;