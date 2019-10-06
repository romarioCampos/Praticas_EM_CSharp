select Bairro, QuantidadeBichosEstimacao 
from Condominio, Morador 
group by Bairro, QuantidadeBichosEstimacao;