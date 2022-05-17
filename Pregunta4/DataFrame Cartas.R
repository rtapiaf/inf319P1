caracteres = c(1,2,3,4,5,6,7,8,9,"A","J","Q","K")
simbolos = c("espada","trebol","diamante","corazon")
colores = c("negro","rojo")
caracteres_ampliado = rep(caracteres,4)
simbolos_ampliado = c(rep(simbolos[1],13),rep(simbolos[2],13),rep(simbolos[3],13),rep(simbolos[4],13))
colores_ampliado = c(rep(colores[1],26),rep(colores[2],26))
mi_df <- data.frame(
  "caracteres" = caracteres_ampliado,
  "simbolos" = simbolos_ampliado,
  "colores" = colores_ampliado
)
mi_df