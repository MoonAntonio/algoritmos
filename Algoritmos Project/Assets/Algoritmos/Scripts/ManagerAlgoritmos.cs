//                                  ┌∩┐(◣_◢)┌∩┐
//																				\\
// ManagerAlgoritmos.cs (04/06/2018)											\\
// Autor: Antonio Mateo (.\Moon Antonio) 	antoniomt.moon@gmail.com			\\
// Descripcion:		Manager general de los algoritmos							\\
// Fecha Mod:		04/06/2018													\\
// Ultima Mod:		Version Inicial												\\
//******************************************************************************\\

#region Librerias
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
#endregion

namespace MoonAntonio
{
	/// <summary>
	/// <para>Manager general de los algoritmos.</para>
	/// </summary>
	public class ManagerAlgoritmos : MonoBehaviour 
	{
		#region Variables Publicas
		/// <summary>
		/// <para>Todas las escenas.</para>
		/// </summary>
		public List<Transform> escenas = new List<Transform>();
		#endregion

		#region Variables Protegidas
		/// <summary>
		/// <para>Id del algoritmo.</para>
		/// </summary>
		protected int idAlgoritmo = 0;
		#endregion


		#region Metodos Publicos
		/// <summary>
		/// <para>Selecciona el id del algoritmo.</para>
		/// </summary>
		/// <param name="id"></param>
		public void SetID(int id)
		{
			idAlgoritmo = id;
			ResetEscena(id);
		}
		#endregion

		#region Metodos Privados
		/// <summary>
		/// <para>Resetea la escena.</para>
		/// </summary>
		/// <param name="id"></param>
		private void ResetEscena(int id)
		{
			foreach (Transform escena in escenas)
			{
				escena.gameObject.SetActive(false);
			}

			switch (id)
			{
				case 0:
					escenas[0].gameObject.SetActive(true);
					break;

				case 1:
					escenas[1].gameObject.SetActive(true);
					break;

				case 2:
					escenas[2].gameObject.SetActive(true);
					break;

				case 3:
					escenas[3].gameObject.SetActive(true);
					break;

				case 4:
					escenas[4].gameObject.SetActive(true);
					break;

				case 5:
					escenas[5].gameObject.SetActive(true);
					break;

				default:
					escenas[0].gameObject.SetActive(true);
					break;
			}

			InitEscena(id);
		}

		/// <summary>
		/// <para>Inicializa la escena seleccionada.</para>
		/// </summary>
		/// <param name="id"></param>
		private void InitEscena(int id)
		{

		}
		#endregion
	}
}