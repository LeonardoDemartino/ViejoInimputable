class Brain{	
	const int STATE_FAIL = -1;
	const int STATE_SUCCESS = 1;
	const int DAYS = 10;

	enum PLACES{
		LAST_ROOM = 1,
		BASEMENT
	}


	enum DefensaHogar {
		STATE_SUCCESS = 1,
		STATE_FAIL
	}

	class ViejoInimputable {
		bool amasijarEngine = false;
		int crazyness = -1;
		public void TakeItToReconditPlace(Chorrito chorro, PLACES place1, PLACES place2) {
			chorro.SetPlaces(place1, place2);
		}

		public bool AmasijarEnElPatio() {
			amasijarEngine = true;
			return true;
		}

		public void SetCrazyEngine(int crazy) {
			crazyness = crazy;
		}

		public void ShootEveryRound(Chorrito chorro) {

		}

		public void Zapatear(Chorrito chorro) {
		}

		public int[] GetShots() {
			int[] tiros = new int[10];
			return tiros;
		}

		public void HabilTirador(bool tirador) {
		}

		public void GarronDeLaGranFlauta(bool garron) {
		}

		public void Inimputable(bool ininputable) {
		}

		public void SetJailTime(int type, int count) {
		}

		public void Mear(Chorrito chorro) {
		}

		public void Papotear(ViejoInimputable papota) {
		}

		public bool HasCocaine() {
			return true;
		}

		public void SetTembleque(bool tembleque) {
		}
	}
	
	class Chorrito {
		int hp;
		PLACES[] places = new PLACES[2];
		public bool IsInside() {
			return true;
		}

		public void SetPlaces(PLACES place1, PLACES place2) {
			places[0] = place1;
			places[1] = place1;
		}

		public void Hide() {
		}
	}

	public class CayoMedianeraException : Exception {

	}

	public class GarronDeLaGranFlautaException : Exception {
	}
	int inconsciencia_temporal = 1;


	ViejoInimputable me = new ViejoInimputable();

	DefensaHogar CheckForChorro(Chorrito chorro) {
		if (chorro.IsInside()) {
			if (me.AmasijarEnElPatio()) {
				throw new CayoMedianeraException();
			}
			me.TakeItToReconditPlace(chorro, PLACES.LAST_ROOM, PLACES.BASEMENT);
			chorro.Hide();
			me.ShootEveryRound(chorro);
			me.Zapatear(chorro);

			if (me.GetShots().Length == 1) {
				me.HabilTirador(true);

				throw new GarronDeLaGranFlautaException();
			}
			me.Mear(chorro);
			me.SetCrazyEngine(inconsciencia_temporal);

			if (me.HasCocaine()) me.Papotear(me);

			me.SetTembleque(true);
			me.Inimputable(true);
			me.SetJailTime(DAYS, 10);

			return DefensaHogar.STATE_SUCCESS;
		}
		return DefensaHogar.STATE_FAIL;
	}
}
