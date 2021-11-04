# Email sender

Projeto .net para envio de e-mails utilizando o serviço AES SES

### Configurações necessárias

- Instalação do AWS CLI [documentação](https://docs.aws.amazon.com/cli/latest/userguide/getting-started-install.html)

- Configuração das credenciais no AWS CLI [documentação](https://docs.aws.amazon.com/cli/latest/userguide/cli-configure-quickstart.html)

  Exemplo:

```bash
$ aws configure
AWS Access Key ID [None]: AKIAIOSFODNN7EXAMPLE
AWS Secret Access Key [None]: wJalrXUtnFEMI/K7MDENG/bPxRfiCYEXAMPLEKEY
Default region name [None]: us-west-2
Default output format [None]: json
```

- AWS SKD SimpleEmailV2 [documentação](https://docs.aws.amazon.com/sdkfornet/v3/apidocs/items/SimpleEmailV2/NSimpleEmailV2.html)
