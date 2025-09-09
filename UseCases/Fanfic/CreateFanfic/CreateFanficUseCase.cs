namespace simulado.UseCases.Fanfic.CreateFanfic;

public class CreateFanficUseCase(
    
)
{
        return Result<CreateFanficResponse>.Success(new());

        //Usuários logados podem criar salas de desenho. Para isso definem o nome da sala e seu tamanho.
        // Existem limites de tamanho com base no tipo de usuário.
        // Usuários com plano Gratuito podem ter salas de até 64x64.
        // Usuários com plano Gold podem ter salas de até 128x128.
        // Usuários com plano Platinum podem ter salas de até 256x256.
    }
}