O `FormProduto` não adiciona diretamente à lista porque sua responsabilidade é somente coletar e validar os dados.
A página `Produtos` é responsável por manter a lista e adicionar o produto recebido.
Quando o cadastro é válido, o formulário usa o `EventCallback<Produto>` para avisar a página.
Assim, o componente filho permanece reutilizável e não depende de onde os produtos são armazenados.
