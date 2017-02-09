#pragma once

namespace RenderEngine {

	enum RasterState { eRS_FILLED = 0, eRS_WIREFRAME, eRS_CCW_WIREFRAME, eRS_CCW, eRS_NO_CULL, eRS_CCW_NO_CULL, eRS_MAX };

	enum VertFormat {
		POS = 0,
		POSCOLOR,
		POSTEX,
		POSNORMTEX,
		POSNORMTANTEX,
		POSBONEWEIGHT,
		POSBONEWEIGHTNORMTEX,
		POSBONEWEIGHTNORMTANTEX,
		MAX
	};

}