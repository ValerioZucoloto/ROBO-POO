using System;

class Robo {
  private string nome;
  private int idade;
  private double ataque;
  private double defesa;
  private string estado;

  public Robo (string nome, int idade, double ataque, double defesa, string estado) {
    this.nome = nome;
    this.idade = idade;
    this.ataque = ataque;
    this.defesa = defesa;
    this.estado = estado;
  }

  public Robo () {
    nome = "Não informado";
    idade = 0;
    ataque = 0.0;
    defesa = 0.0;
    estado = "Nao informado";
  }

  public string GetEstado(){
    return estado;
  }

  public string GetNome () {
    return nome;
  }

  public void SetNome (string N) {
    nome = N;
  }

  public int Getidade () {
    return idade;
  }

  public void SetIdade (int I) {
    idade = I;
  }

  public double GetDefesa(){
    return defesa;
  }

  public double GetAtaque(){
    return ataque;
  }

  public bool RealizarAtaque (Robo outroRobo) {
    //Um robô só pode atacar se possuir pelo menos 10% de força de ataque e se estiver no estado Normal ou Fraco.
    if (this.ataque  >= 10 && this.estado == "normal" ||  this.ataque  >= 10 && this.estado == "fraco") {
      this.ataque = this.ataque - 20;
      outroRobo.defesa = outroRobo.defesa - 20;

      //Caso sua força de defesa fique abaixo de 40% ele passa para o estado Fraco
    if(outroRobo.defesa <= 40){
        outroRobo.estado = "fraco";
    }


    //caso fique abaixo de 0% ele passa para o estado Indefeso
      if (outroRobo.defesa <= 0) {
        outroRobo.estado = "Indefeso";
      }

    return true;

    }

    return false;
  }

  public void DoarForcaDefesa (Robo roboRecebedor, double percentual) {
      if (this.estado == "normal" && this.defesa - percentual >= 40) {

        this.defesa = this.defesa - percentual;
         roboRecebedor.defesa = roboRecebedor.defesa + percentual;

      Console.WriteLine("Doação Realizada com Sucesso");
      Console.WriteLine("Força de Defesa do Doador: " + this.defesa + "%");
      Console.WriteLine("Força de Defesa do Recebedor: " + roboRecebedor.defesa + "%");
    }else{
      Console.WriteLine("Não foi possível doar força de Defesa");
    }
      
    }

  
}